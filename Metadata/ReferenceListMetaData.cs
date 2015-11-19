﻿using MrCMS.Entities.Documents.Metadata;
using MrCMS.Web.Apps.References.Pages;

namespace MrCMS.Web.Apps.References.Metadata
{
    public class ReferenceListMetaData : DocumentMetadataMap<ReferenceList>
    {
        public override string WebGetController
        {
            get { return "Reference"; }
        }
        public override string IconClass
        {
            get { return "glyphicon glyphicon-list"; }
        }
        
       

       
    }
}

