using System;
using CommonModels;

namespace RequestBuilderSwitch
{
    public class RequestBuilder
    {
        public static User CreateUser(User newUser)
        {
            if(newUser == null)
                throw new ArgumentNullException();

            return new User
            {
                Id = 1
            };
        }
    }
}
