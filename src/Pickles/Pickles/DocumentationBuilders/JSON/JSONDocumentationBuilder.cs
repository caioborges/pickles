﻿#region License

/*
    Copyright [2011] [Jeffrey Cameron]

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

#endregion

using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using NGenerics.DataStructures.Trees;
using NGenerics.Patterns.Visitor;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Pickles.DirectoryCrawler;
using Pickles.TestFrameworks;
using log4net;

namespace Pickles.DocumentationBuilders.JSON
{
    public class JSONDocumentationBuilder : IDocumentationBuilder
    {
        public const string JsonFileName = @"pickledFeatures.json";
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly Configuration configuration;
        private readonly ITestResults testResults;


        public JSONDocumentationBuilder(Configuration configuration, ITestResults testResults)
        {
            this.configuration = configuration;
            this.testResults = testResults;
        }

        private string OutputFilePath
        {
            get { return Path.Combine(configuration.OutputFolder.FullName, JsonFileName); }
        }

        #region IDocumentationBuilder Members

        public void Build(GeneralTree<IDirectoryTreeNode> features)
        {
            if (log.IsInfoEnabled)
            {
                log.InfoFormat("Writing JSON to {0}", configuration.OutputFolder.FullName);
            }

            var featuresToFormat = new List<FeatureWithMetaInfo>();

            var actionVisitor = new ActionVisitor<IDirectoryTreeNode>(node =>
                                                                          {
                                                                              var featureTreeNode =
                                                                                  node as FeatureDirectoryTreeNode;
                                                                              if (featureTreeNode != null)
                                                                              {
                                                                                  if (configuration.HasTestResults)
                                                                                  {
                                                                                      featuresToFormat.Add(
                                                                                          new FeatureWithMetaInfo(
                                                                                              featureTreeNode,
                                                                                              testResults.
                                                                                                  GetFeatureResult(
                                                                                                      featureTreeNode.
                                                                                                          Feature)));
                                                                                  }
                                                                                  else
                                                                                  {
                                                                                      featuresToFormat.Add(
                                                                                          new FeatureWithMetaInfo(
                                                                                              featureTreeNode));
                                                                                  }
                                                                              }
                                                                          });

            features.AcceptVisitor(actionVisitor);

            CreateFile(OutputFilePath, GenerateJSON(featuresToFormat));
        }

        #endregion

        private static string GenerateJSON(List<FeatureWithMetaInfo> features)
        {
            var settings = new JsonSerializerSettings
                               {
                                   ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                   NullValueHandling = NullValueHandling.Ignore,
                                   Converters = new List<JsonConverter> {new StringEnumConverter()}
                               };

            return JsonConvert.SerializeObject(features, Formatting.Indented, settings);
        }

        private static void CreateFile(string outputFolderName, string jsonToWrite)
        {
            using (var writer = new StreamWriter(outputFolderName, false, Encoding.UTF8))
            {
                writer.Write(jsonToWrite);
                writer.Close();
            }
        }
    }
}