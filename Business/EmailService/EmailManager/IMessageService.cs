﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.EmailService.EmailManager
{
    public interface IMessageService
    {
        
		Task NotifyPlayerForAttention(string participantId, string subject, string message, string scheduledMeetingId);
    }
}

