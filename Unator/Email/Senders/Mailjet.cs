﻿namespace Unator.Email.Senders;

public class Mailjet : UEmailSender
{
    public bool IsLimitAllow()
    {
        throw new NotImplementedException();
    }

    public Exception? SendEmailAsync(string from, string to, string subject, string html)
    {
        return new NotImplementedException();
    }
}