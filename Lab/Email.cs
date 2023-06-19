﻿using Lab.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unator.Email;
using Unator.Email.Senders;

namespace Lab;

/*
    Services I am looking at now:
    |                                                       | Free limit               |
    | ----------------------------------------------------- | ------------------------ |
    | [Resend] (https://resend.com/)                        | 3000/month (max 100/day) |
    | [Brevo] (https://www.brevo.com/)                      | 300/day                  |
    | [SendGrid] (https://sendgrid.com/)                    | 100/day                  |
    | [Mailchimp] (https://mailchimp.com/)                  | 1000/month (max 500/day) |
    | [Mailjet] (https://www.mailjet.com/)                  | 6000/month (max 200/day) |
    | [Postmark] (https://postmarkapp.com/)                 | 100/month                |
    | [Elastic email] (https://elasticemail.com/)           | 100/day                  |
    | [Amazon SES] (https://aws.amazon.com/ru/ses/pricing/) | 62000/month ?            |
*/

/// <summary>
/// Experiments to email sending with EmailGod
/// </summary>
public static class Email
{
    /// <summary>
    /// Start experiments with email sending.
    /// </summary>
    /// <returns></returns>
    public static async Task Start()
    {
        var god = new EmailGod(
            new Resend(Secrets.ResendApiKey, new DateTime(2023, 6, 16), 1, 1), // 1,1 for testing
            new Brevo(Secrets.BrevoApiKey, 1)
        );

        //god.Add(new SendGrid());
        //god.Add(new Mailchimp());
        //god.Add(new Mailjet());

        var error = await god.Send("roman@paragoda.tech", "romankoshchei@gmail.com", "Testing Email God 1", "<strong>It works!</strong>");

        if (error != null)
        {
            Console.WriteLine(error.Message.ToString());
        }

        error = await god.Send("roman@paragoda.tech", "romankoshchei@gmail.com", "Testing Email God 2", "<strong>It works!</strong>");

        if (error != null)
        {
            Console.WriteLine(error.Message.ToString());
        }

        error = await god.Send("roman@paragoda.tech", "romankoshchei@gmail.com", "Testing Email God 3", "<strong>Should fail!</strong>");

        if (error != null)
        {
            Console.WriteLine(error.Message.ToString());
        }
    }
}