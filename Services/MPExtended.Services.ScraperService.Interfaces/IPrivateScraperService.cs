﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MPExtended.Services.Common.Interfaces;

namespace MPExtended.Services.ScraperService.Interfaces
{
    [ServiceContract(Namespace = "http://mpextended.github.com")]
    public interface IPrivateScraperService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebScraper GetScraperDescription();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult StartScraper();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult StopScraper();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult PauseScraper();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult ResumeScraper();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult TriggerUpdate();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebScraperStatus GetScraperStatus();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebScraperInputRequest GetScraperInputRequest(int index);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        IList<WebScraperInputRequest> GetAllScraperInputRequests();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult SetScraperInputRequest(String requestId, String matchId, String text);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult AddItemToScraper(String title, WebMediaType type, int? provider, string itemId, int? offset);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<WebScraperItem> GetScraperItems();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<WebScraperAction> GetScraperActions();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebBoolResult InvokeScraperAction(string itemId, string actionId);
    }
}