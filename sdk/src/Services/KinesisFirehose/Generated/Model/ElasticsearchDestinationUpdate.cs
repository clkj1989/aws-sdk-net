/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes an update for a destination in Amazon ES.
    /// </summary>
    public partial class ElasticsearchDestinationUpdate
    {
        private ElasticsearchBufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private string _domainARN;
        private string _indexName;
        private ElasticsearchIndexRotationPeriod _indexRotationPeriod;
        private ElasticsearchRetryOptions _retryOptions;
        private string _roleARN;
        private S3DestinationUpdate _s3Update;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// Buffering options. If no value is specified, <b>ElasticsearchBufferingHints</b> object
        /// default values are used. 
        /// </para>
        /// </summary>
        public ElasticsearchBufferingHints BufferingHints
        {
            get { return this._bufferingHints; }
            set { this._bufferingHints = value; }
        }

        // Check to see if BufferingHints property is set
        internal bool IsSetBufferingHints()
        {
            return this._bufferingHints != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// Describes CloudWatch logging options for your delivery stream.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DomainARN. 
        /// <para>
        /// The ARN of the Amazon ES domain. The IAM role must have permission for DescribeElasticsearchDomain,
        /// DescribeElasticsearchDomains , and DescribeElasticsearchDomainConfig after assuming
        /// <b>RoleARN</b>.
        /// </para>
        /// </summary>
        public string DomainARN
        {
            get { return this._domainARN; }
            set { this._domainARN = value; }
        }

        // Check to see if DomainARN property is set
        internal bool IsSetDomainARN()
        {
            return this._domainARN != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The Elasticsearch index name.
        /// </para>
        /// </summary>
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexRotationPeriod. 
        /// <para>
        /// The Elasticsearch index rotation period. Index rotation appends a timestamp to the
        /// IndexName to facilitate the expiration of old data. For more information, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/basic-deliver.html#es-index-rotation">Index
        /// Rotation for Amazon Elasticsearch Service Destination</a>. Default value is <code>OneDay</code>.
        /// </para>
        /// </summary>
        public ElasticsearchIndexRotationPeriod IndexRotationPeriod
        {
            get { return this._indexRotationPeriod; }
            set { this._indexRotationPeriod = value; }
        }

        // Check to see if IndexRotationPeriod property is set
        internal bool IsSetIndexRotationPeriod()
        {
            return this._indexRotationPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// Configures retry behavior in the event that Firehose is unable to deliver documents
        /// to Amazon ES. Default value is 300 (5 minutes).
        /// </para>
        /// </summary>
        public ElasticsearchRetryOptions RetryOptions
        {
            get { return this._retryOptions; }
            set { this._retryOptions = value; }
        }

        // Check to see if RetryOptions property is set
        internal bool IsSetRetryOptions()
        {
            return this._retryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the IAM role to be assumed by Firehose for calling the Amazon ES Configuration
        /// API and for indexing documents. For more information, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Amazon
        /// S3 Bucket Access</a>.
        /// </para>
        /// </summary>
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3Update.
        /// </summary>
        public S3DestinationUpdate S3Update
        {
            get { return this._s3Update; }
            set { this._s3Update = value; }
        }

        // Check to see if S3Update property is set
        internal bool IsSetS3Update()
        {
            return this._s3Update != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The Elasticsearch type name.
        /// </para>
        /// </summary>
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}