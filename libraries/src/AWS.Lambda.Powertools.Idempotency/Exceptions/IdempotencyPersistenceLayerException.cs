/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;

namespace AWS.Lambda.Powertools.Idempotency.Exceptions;

/// <summary>
/// Exception thrown when a technical error occurred with the persistence layer (eg. insertion, deletion, ... in database)
/// </summary>
public class IdempotencyPersistenceLayerException : Exception
{
    /// <summary>
    /// Creates a new IdempotencyPersistenceLayerException 
    /// </summary>
    public IdempotencyPersistenceLayerException()
    {
    }

    /// <inheritdoc />
    public IdempotencyPersistenceLayerException(string? message) : base(message)
    {
    }

    /// <inheritdoc />
    public IdempotencyPersistenceLayerException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}