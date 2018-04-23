﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EVEStandard.Models
{
    public class MailRecipient : ModelBase<MailRecipient>
    {
        /// <summary>
        /// recipient_type string
        /// </summary>
        /// <value>recipient_type string</value>
        public enum RecipientTypeEnum
        {
            alliance = 1,
            character = 2,
            corporation = 3,
            mailing_list = 4
        }

        /// <summary>
        /// recipient_type string
        /// </summary>
        /// <value>recipient_type string</value>
        [JsonProperty("recipient_type")]
        public RecipientTypeEnum? RecipientType { get; set; }

        /// <summary>
        /// recipient_id integer
        /// </summary>
        /// <value>recipient_id integer</value>
        [JsonProperty("recipient_id")]
        public int? RecipientId { get; set; }
    }
}
