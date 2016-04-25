// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Search;

namespace Microsoft.Azure.Search
{
    /// <summary>
    /// Client that can be used to query an Azure Search index and upload,
    /// merge, or delete documents.  (see
    /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
    /// information)
    /// </summary>
    public partial interface ISearchIndexClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets the credentials used to authenticate to an Azure Search
        /// service.  (see
        /// https://msdn.microsoft.com/library/azure/dn798935.aspx for more
        /// information)
        /// </summary>
        SearchCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Operations for querying an index and uploading, merging, and
        /// deleting documents.  (see
        /// https://msdn.microsoft.com/library/azure/dn800962.aspx for more
        /// information)
        /// </summary>
        IDocumentOperations Documents
        {
            get; 
        }
    }
}