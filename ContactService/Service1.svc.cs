using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContactService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public StatusContract addAccount(AccountContract account)
        {
            StatusContract result = new StatusContract();

            result.Message = "OK";

            return result;
        }

        public AccountContract getAccount()
        {
            AccountContract result;

            result = new AccountContract { Name = "พล", Email = "teerasej@nextflow.in.th", Tel = "083-071-3373" };


            return result;
        }

        public List<AccountContract> getAccounts()
        {
            List<AccountContract> results = new List<AccountContract>();

            results.Add(new AccountContract
            {
                Name = "พล"
                ,
                Email = "teerasej@nextflow.in.th"
                ,
                Tel = "083-071-3373"
            });

            results.Add(new AccountContract
            {
                Name = "John"
                ,
                Email = "johndoe@apple.com"
                ,
                Tel = "018-190-3881"
            });

            results.Add(new AccountContract
            {
                Name = "Tony Stark"
                ,
                Email = "tony@stark.com"
                ,
                Tel = "083-391-3918"
            });

            results.Add(new AccountContract
            {
                Name = "Jack Sparrow"
                ,
                Email = "jack@sparrow.net"
                ,
                Tel = "082-198-2837"
            });

            results.Add(new AccountContract
            {
                Name = "Mitsuha"
                ,
                Email = "mitsuha@yourname.com"
                ,
                Tel = "087-291-3871"
            });

            return results;

        }




    }
}
