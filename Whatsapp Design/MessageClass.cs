using System.Collections.Generic;

namespace Whatsapp_Design.Models;

public class MessageClass
{

    public string? Hour { get; set; }
    public string? Text { get; set; }

    public List<MessageClass> user1_messages { get; set; }
    public List<MessageClass> user2_messages { get; set; }



    public MessageClass()
    {
        user1_messages = new()
        {
            new MessageClass(){Hour = "10:13", Text = "Salam Vusal Necesen? " },
            new MessageClass(){Hour = "10:16", Text = "Sagol mende yaxsiyam. Sabah derse geleceksen?" },
        };

        user2_messages = new()
        {
            new MessageClass(){Hour = "10:15", Text = "Salam Huseyn. Yaxsiyam sen necesen?" },
            new MessageClass(){Hour = "10:18", Text = "Hee gelecem" },
        };
    }


    public MessageClass(string? hour, string? text)
    {
        Hour = hour;
        Text = text;
    }



}
