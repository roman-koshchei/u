﻿namespace Unator.Email.Senders;

public class Mailjet : UEmailSender
{
    public long GetMonthLimit()
    {
        throw new NotImplementedException();
    }

    public bool IsLimitAllow()
    {
        throw new NotImplementedException();
    }

    public Task<Exception?> SendEmail(string from, string to, string subject, string html)
    {
        throw new NotImplementedException();
    }

    public Exception? SendEmailAsync(string from, string to, string subject, string html)
    {
        return new NotImplementedException();
    }
}