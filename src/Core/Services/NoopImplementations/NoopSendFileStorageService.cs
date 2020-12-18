﻿using System.Threading.Tasks;
using System.IO;
using System;
using Bit.Core.Models.Table;

namespace Bit.Core.Services
{
    public class NoopSendFileStorageService : ISendFileStorageService
    {
        public Task UploadNewFileAsync(Stream stream, Send send, string attachmentId)
        {
            return Task.FromResult(0);
        }

        public Task DeleteFileAsync(string fileId)
        {
            return Task.FromResult(0);
        }

        public Task DeleteFilesForOrganizationAsync(Guid organizationId)
        {
            return Task.FromResult(0);
        }

        public Task DeleteFilesForUserAsync(Guid userId)
        {
            return Task.FromResult(0);
        }
    }
}
