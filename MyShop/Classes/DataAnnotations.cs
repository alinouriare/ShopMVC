using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class DisplayPluralNameAttribute : Attribute, IMetadataAware
    {
        public string DisplyNamePlural { get; set; }

        public DisplayPluralNameAttribute(string DisplyNamePlural)
        {
            this.DisplyNamePlural = DisplyNamePlural;
        }
        public void OnMetadataCreated(ModelMetadata metadata)
        {
            metadata.AdditionalValues.Add("DisplyNamePlural", DisplyNamePlural);
        }
    }
}