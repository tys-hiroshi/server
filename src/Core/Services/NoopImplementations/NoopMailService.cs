﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.Core.Models.Table;

namespace Bit.Core.Services
{
    public class NoopMailService : IMailService
    {
        public Task SendChangeEmailAlreadyExistsEmailAsync(string fromEmail, string toEmail)
        {
            return Task.FromResult(0);
        }

        public Task SendVerifyEmailEmailAsync(string email, Guid userId, string hint)
        {
            return Task.FromResult(0);
        }

        public Task SendChangeEmailEmailAsync(string newEmailAddress, string token)
        {
            return Task.FromResult(0);
        }

        public Task SendMasterPasswordHintEmailAsync(string email, string hint)
        {
            return Task.FromResult(0);
        }

        public Task SendNoMasterPasswordHintEmailAsync(string email)
        {
            return Task.FromResult(0);
        }

        public Task SendOrganizationAcceptedEmailAsync(string organizationName, string userEmail, IEnumerable<string> adminEmails)
        {
            return Task.FromResult(0);
        }

        public Task SendOrganizationConfirmedEmailAsync(string organizationName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendOrganizationInviteEmailAsync(string organizationName, OrganizationUser orgUser, string token)
        {
            return Task.FromResult(0);
        }

        public Task SendOrganizationUserRemovedForPolicyTwoStepEmailAsync(string organizationName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendTwoFactorEmailAsync(string email, string token)
        {
            return Task.FromResult(0);
        }

        public Task SendWelcomeEmailAsync(User user)
        {
            return Task.FromResult(0);
        }

        public Task SendVerifyDeleteEmailAsync(string email, Guid userId, string token)
        {
            return Task.FromResult(0);
        }

        public Task SendPasswordlessSignInAsync(string returnUrl, string token, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendInvoiceUpcomingAsync(string email, decimal amount, DateTime dueDate,
            List<string> items, bool mentionInvoices)
        {
            return Task.FromResult(0);
        }

        public Task SendPaymentFailedAsync(string email, decimal amount, bool mentionInvoices)
        {
            return Task.FromResult(0);
        }

        public Task SendAddedCreditAsync(string email, decimal amount)
        {
            return Task.FromResult(0);
        }

        public Task SendLicenseExpiredAsync(IEnumerable<string> emails, string organizationName = null)
        {
            return Task.FromResult(0);
        }

        public Task SendNewDeviceLoggedInEmail(string email, string deviceType, DateTime timestamp, string ip)
        {
            return Task.FromResult(0);
        }

        public Task SendRecoverTwoFactorEmail(string email, DateTime timestamp, string ip)
        {
            return Task.FromResult(0);
        }

        public Task SendOrganizationUserRemovedForPolicySingleOrgEmailAsync(string organizationName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessInviteEmailAsync(EmergencyAccess emergencyAccess, string name, string token)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessAcceptedEmailAsync(string granteeEmail, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessConfirmedEmailAsync(string grantorName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessRecoveryInitiated(EmergencyAccess emergencyAccess, string initiatingName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessRecoveryApproved(EmergencyAccess emergencyAccess, string approvingName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessRecoveryRejected(EmergencyAccess emergencyAccess, string rejectingName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessRecoveryReminder(EmergencyAccess emergencyAccess, string initiatingName, string email)
        {
            return Task.FromResult(0);
        }

        public Task SendEmergencyAccessRecoveryTimedOut(EmergencyAccess ea, string initiatingName, string email)
        {
            return Task.FromResult(0);
        }
    }
}
