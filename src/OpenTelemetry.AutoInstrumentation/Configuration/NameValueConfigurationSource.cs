// <copyright file="NameValueConfigurationSource.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.Collections.Specialized;

namespace OpenTelemetry.AutoInstrumentation.Configuration;

/// <summary>
/// Represents a configuration source that retrieves
/// values from the provided <see cref="NameValueCollection"/>.
/// </summary>
internal class NameValueConfigurationSource : StringConfigurationSource
{
    private readonly NameValueCollection _nameValueCollection;

    /// <summary>
    /// Initializes a new instance of the <see cref="NameValueConfigurationSource"/> class
    /// that wraps the specified <see cref="NameValueCollection"/>.
    /// </summary>
    /// <param name="nameValueCollection">The collection that will be wrapped by this configuration source.</param>
    public NameValueConfigurationSource(NameValueCollection nameValueCollection)
    {
        _nameValueCollection = nameValueCollection;
    }

    protected override string? GetStringInternal(string key)
    {
        return _nameValueCollection[key];
    }
}
