//
//  ICollectionMapping.cs
//
//  Author:
//       Craig Fowler <craig@craigfowler.me.uk>
//
//  Copyright (c) 2012 Craig Fowler
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace CSF.KeyValueSerializer.MappingModel
{
  /// <summary>
  /// Marker interface for a mapping that relates to a collection.
  /// </summary>
  public interface ICollectionMapping : IMapping
  {
    /// <summary>
    /// Gets the type of collection keying in-use.
    /// </summary>
    /// <value>
    /// The type of the collection key.
    /// </value>
    CollectionKeyType CollectionKeyType { get; set; }

    /// <summary>
    /// Gets or sets the minimum 'array index' used whilst searching for values to deserialize.
    /// </summary>
    /// <value>
    /// The minimum 'array index' for deserialization.
    /// </value>
    int DeserializeMinimumIndex { get; set; }

    /// <summary>
    /// Gets or sets the maximum 'array index' used whilst searching for values to deserialize.
    /// </summary>
    /// <value>
    /// The maximum 'array index' for deserialization.
    /// </value>
    int DeserializeMaximumIndex { get; set; }
  }
}

