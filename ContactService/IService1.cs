using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ContactService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate="/account/sample"
            , ResponseFormat =WebMessageFormat.Json)]
        AccountContract getAccount();

        [OperationContract]
        [WebGet(UriTemplate = "/account/list"
            , ResponseFormat = WebMessageFormat.Json)]
        List<AccountContract> getAccounts();

        [OperationContract]
        [WebInvoke(UriTemplate = "/account/add"
            , RequestFormat = WebMessageFormat.Json
            , ResponseFormat = WebMessageFormat.Json
            , Method = "POST")]
        bool addAccount(AccountContract account);

        // TODO: Add your service operations here
    }


}
