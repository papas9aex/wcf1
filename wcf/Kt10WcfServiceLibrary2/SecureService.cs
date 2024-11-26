using Kt10WcfServiceLibrary2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Xml.Linq;

namespace Kt10WcfServiceLibrary2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : ISecureService
    {
        public string SecureMethod(string input)
        {
            return "Response from SecureMethod: " + input;
        }
 //       	<appSettings>
	//	<add key = "aspnet:UseTaskFriendlySynchronizationContext" value="true" />
	//</appSettings>
	//<system.web>
	//	<compilation debug = "true" />

 //   </ system.web >

 //   < system.serviceModel >

 //       < services >

 //           < service name="Kt10WcfServiceLibrary2.Service1">
	//			<endpoint address = "" binding="wsHttpBinding" contract="Kt10WcfServiceLibrary2.ISecureService">
	//			</endpoint>
	//			<endpoint address = "mex" binding="mexHttpBinding" contract="IMetadataExchange" />
	//			<host>
	//				<baseAddresses>
	//					<add baseAddress = "http://localhost:8733/Design_Time_Addresses/Kt10WcfServiceLibrary2/Service1/" />

 //                   </ baseAddresses >

 //               </ host >

 //           </ service >

 //       </ services >

 //       < behaviors >

 //           < serviceBehaviors >

 //               < behavior >

 //                   < serviceMetadata httpGetEnabled="True" httpsGetEnabled="True"/>
	//				<serviceDebug includeExceptionDetailInFaults = "False" />

 //               </ behavior >

 //           </ serviceBehaviors >

 //       </ behaviors >

 //   </ system.serviceModel >
    }
}
//< configuration >


//    < appSettings >

//        < add key = "aspnet:UseTaskFriendlySynchronizationContext" value = "true" />

//    </ appSettings >

//    < system.web >

//        < compilation debug = "true" />

//    </ system.web >

//    < system.serviceModel >

//        < services >

//            < service name = "Kt10WcfServiceLibrary2.Service1" >

//                < endpoint address = "" binding = "wsHttpBinding" contract = "Kt10WcfServiceLibrary2.ISecureService" >

//                </ endpoint >

//                < endpoint address = "mex" binding = "mexHttpBinding" contract = "IMetadataExchange" />

//                < host >

//                    < baseAddresses >

//                        < add baseAddress = "http://localhost:8733/Design_Time_Addresses/Kt10WcfServiceLibrary2/Service1/" />

//                    </ baseAddresses >

//                </ host >

//            </ service >

//        </ services >

//        < behaviors >

//            < serviceBehaviors >

//                < behavior >

//                    < serviceMetadata httpGetEnabled = "True" httpsGetEnabled = "True" />

//                    < serviceDebug includeExceptionDetailInFaults = "False" />

//                </ behavior >

//            </ serviceBehaviors >

//        </ behaviors >

//    </ system.serviceModel >

//</ configuration >









