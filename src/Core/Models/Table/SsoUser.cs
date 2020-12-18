﻿using System;

namespace Bit.Core.Models.Table
{
    public class SsoUser : ITableObject<long>
    {
        public long Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? OrganizationId { get; set; }
        public string ExternalId { get; set; }
        public DateTime CreationDate { get; internal set; } = DateTime.UtcNow;

        public void SetNewId()
        {
            // nothing - int will be auto-populated
        }
    }
}
