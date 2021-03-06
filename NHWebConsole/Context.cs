﻿#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System.Collections.Generic;

namespace NHWebConsole {
    public class Context {
        public string Url { get; set; }
        public string Query { get; set; }
        public QueryType QueryType { get; set; }
        public int? MaxResults { get; set; }
        public int? FirstResult { get; set; }
        public ICollection<Row> Results { get; set; }
        public int Total { get; set; }
        public string Error { get; set; }
        public string NextPageUrl { get; set; }
        public string PrevPageUrl { get; set; }
        public string FirstPageUrl { get; set; }
        public bool LimitLength { get; set; }
        public object RawResult { get; set; }
        public bool Raw { get; set; }
        public string[] ImageFields { get; set; }
        public string ContentType { get; set; }
        public ICollection<KeyValuePair<string, string>> AllEntities { get; set; }
        public string Output { get; set; }
        public string RssUrl { get; set; }
        public string ExtraRowTemplate { get; set; }
        public string Version { get; set; }
    }

    public class Row : List<KeyValuePair<string, string>> {
    }

    public enum OperationType {
        List,
        Update,
    }

    public enum QueryType {
        SQL,
        HQL,
    }
}