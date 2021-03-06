﻿using System.Collections.Generic;
using System.ComponentModel;

namespace IdokladSdk.ApiModels.BaseModels
{
    public class ApiModel : IApiModel
    {
        public ApiModel()
        {
            Links = new Dictionary<string, string>();
        }

        /// <summary>
        /// Resource identifier
        /// </summary>
        [ReadOnly(true)]
        public virtual int Id { get; set; }

        /// <summary>
        /// List of resource links
        /// </summary>
        [ReadOnly(true)]
        public IDictionary<string, string> Links { get; set; }
    }
}