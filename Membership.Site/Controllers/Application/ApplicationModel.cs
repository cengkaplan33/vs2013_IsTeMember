﻿using System;

namespace Membership.Site.Model
{
    public class ApplicationModel
    {
        public int Id { get; set; }
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }
        public byte Status { get; set; }
    }
}