﻿using DoanApp.Models;
using DoanData.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoanApp.Services
{
    public interface IMessageService
    {
        List<Message> GetAll();
        List<Message_Vm> GetUserNoneChat(List<Message_Vm> message_Vms,int userId,List<AppUser> users);
        Message GetUserInList(Message message);
        List<Message> GetMessage_Partial(int senderId, int receiverId, bool flag = false);
        List<Message_Vm> GetUserChat(int userId, List<AppUser> users);
        Task<int> Create(MessageRequest request,bool admin);
        Task<int> Delete(int id);
        Task<int> Update(MessageRequest request);
        Task<int> UpdateWatched(int senderId, int receiverId,bool flag);
        Task<int> UpdateAvartar(int userId, string img);
        Task<Message> FindMessageAsync(int id);
        Task<bool> CreateXMLMessage(Message request);
       Task<IEnumerable<XElement>> FindElementById(int id, XDocument doc);
        int CheckIdMessage(string pathXML);
        Task<int> UpdateNameChannel(int userId, string username);

    }
}
