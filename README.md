# NiFi.Swagger.Core
.NET Core Client for Apache NiFi using swagger-cogeden


To install NiFi.Swagger.Core from within Visual Studio, search for NiFi.Swagger.Core in the NuGet Package Manager UI, or run the following command in the Package Manager Console:

```
Install-Package NiFi.Swagger.Core -Version 1.9.1
```

### Which version 

The version of product correspond to the nifi api version.

sample 1.9.1 is build with API Nifi 1.9.1

| version         | version NIFI             |
| --------------- | -------------------------|
| version 1.9.1 | Build with api nifi  1.9.1 |

## Getting Started

System Diagnostics Api Example 

```C#

namespace NiFi.Swagger.SystemDiagnosticsApiExample
{
    using System;

    using NiFi.Swagger.Api;
    using NiFi.Swagger.Client;

    using Console = System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var config = new Configuration
                {
                    BasePath = "http://localhost:8080/nifi-api"
                };

                var systemApi = new SystemDiagnosticsApi(config);

                var localDiagnostics = systemApi.GetSystemDiagnostics();
                Console.WriteLine(localDiagnostics.ToJson());

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *http://localhost:8080/nifi/*

All URIs are relative to *http://localhost/nifi/*

| Class                    | Method                                   | HTTP request                             | Description                              |
| ------------------------ | ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| *AccessApi*              | [**CreateAccessToken**](Docs/AccessApi.md#createAccessToken) | **POST** /access/token                   | Creates a token for accessing the REST API via username/password |
| *AccessApi*              | [**CreateAccessTokenFromTicket**](Docs/AccessApi.md#createAccessTokenFromTicket) | **POST** /access/kerberos                | Creates a token for accessing the REST API via Kerberos ticket exchange / SPNEGO negotiation |
| *AccessApi*              | [**CreateDownloadToken**](Docs/AccessApi.md#createDownloadToken) | **POST** /access/download-token          | Creates a single use access token for downloading FlowFile content. |
| *AccessApi*              | [**CreateUiExtensionToken**](Docs/AccessApi.md#createUiExtensionToken) | **POST** /access/ui-extension-token      | Creates a single use access token for accessing a NiFi UI extension. |
| *AccessApi*              | [**GetAccessStatus**](Docs/AccessApi.md#getAccessStatus) | **GET** /access                          | Gets the status the client&#39;s access  |
| *AccessApi*              | [**GetLoginConfig**](Docs/AccessApi.md#getLoginConfig) | **GET** /access/config                   | Retrieves the access configuration for this NiFi |
| *ConnectionsApi*         | [**DeleteConnection**](Docs/ConnectionsApi.md#deleteConnection) | **DELETE** /connections/{id}             | Deletes a connection                     |
| *ConnectionsApi*         | [**GetConnection**](Docs/ConnectionsApi.md#getConnection) | **GET** /connections/{id}                | Gets a connection                        |
| *ConnectionsApi*         | [**UpdateConnection**](Docs/ConnectionsApi.md#updateConnection) | **PUT** /connections/{id}                | Updates a connection                     |
| *ControllerApi*          | [**CreateBulletin**](Docs/ControllerApi.md#createBulletin) | **POST** /controller/bulletin            | Creates a new bulletin                   |
| *ControllerApi*          | [**CreateControllerService**](Docs/ControllerApi.md#createControllerService) | **POST** /controller/controller-services | Creates a new controller service         |
| *ControllerApi*          | [**CreateReportingTask**](Docs/ControllerApi.md#createReportingTask) | **POST** /controller/reporting-tasks     | Creates a new reporting task             |
| *ControllerApi*          | [**DeleteHistory**](Docs/ControllerApi.md#deleteHistory) | **DELETE** /controller/history           | Purges history                           |
| *ControllerApi*          | [**DeleteNode**](Docs/ControllerApi.md#deleteNode) | **DELETE** /controller/cluster/nodes/{id} | Removes a node from the cluster          |
| *ControllerApi*          | [**GetCluster**](Docs/ControllerApi.md#getCluster) | **GET** /controller/cluster              | Gets the contents of the cluster         |
| *ControllerApi*          | [**GetControllerConfig**](Docs/ControllerApi.md#getControllerConfig) | **GET** /controller/config               | Retrieves the configuration for this NiFi Controller |
| *ControllerApi*          | [**GetNode**](Docs/ControllerApi.md#getNode) | **GET** /controller/cluster/nodes/{id}   | Gets a node in the cluster               |
| *ControllerApi*          | [**UpdateControllerConfig**](Docs/ControllerApi.md#updateControllerConfig) | **PUT** /controller/config               | Retrieves the configuration for this NiFi |
| *ControllerApi*          | [**UpdateNode**](Docs/ControllerApi.md#updateNode) | **PUT** /controller/cluster/nodes/{id}   | Updates a node in the cluster            |
| *ControllerServicesApi*  | [**ClearState**](Docs/ControllerServicesApi.md#clearState) | **POST** /controller-services/{id}/state/clear-requests | Clears the state for a controller service |
| *ControllerServicesApi*  | [**GetControllerService**](Docs/ControllerServicesApi.md#getControllerService) | **GET** /controller-services/{id}        | Gets a controller service                |
| *ControllerServicesApi*  | [**GetControllerServiceReferences**](Docs/ControllerServicesApi.md#getControllerServiceReferences) | **GET** /controller-services/{id}/references | Gets a controller service                |
| *ControllerServicesApi*  | [**GetPropertyDescriptor**](Docs/ControllerServicesApi.md#getPropertyDescriptor) | **GET** /controller-services/{id}/descriptors | Gets a controller service property descriptor |
| *ControllerServicesApi*  | [**GetState**](Docs/ControllerServicesApi.md#getState) | **GET** /controller-services/{id}/state  | Gets the state for a controller service  |
| *ControllerServicesApi*  | [**RemoveControllerService**](Docs/ControllerServicesApi.md#removeControllerService) | **DELETE** /controller-services/{id}     | Deletes a controller service             |
| *ControllerServicesApi*  | [**UpdateControllerService**](Docs/ControllerServicesApi.md#updateControllerService) | **PUT** /controller-services/{id}        | Updates a controller service             |
| *ControllerServicesApi*  | [**UpdateControllerServiceReferences**](Docs/ControllerServicesApi.md#updateControllerServiceReferences) | **PUT** /controller-services/{id}/references | Updates a controller services references |
| *CountersApi*            | [**GetCounters**](Docs/CountersApi.md#getCounters) | **GET** /counters                        | Gets the current counters for this NiFi  |
| *CountersApi*            | [**UpdateCounter**](Docs/CountersApi.md#updateCounter) | **PUT** /counters/{id}                   | Updates the specified counter. This will reset the counter value to 0 |
| *DataTransferApi*        | [**CommitInputPortTransaction**](Docs/DataTransferApi.md#commitInputPortTransaction) | **DELETE** /data-transfer/input-ports/{portId}/transactions/{transactionId} | Commit or cancel the specified transaction |
| *DataTransferApi*        | [**CommitOutputPortTransaction**](Docs/DataTransferApi.md#commitOutputPortTransaction) | **DELETE** /data-transfer/output-ports/{portId}/transactions/{transactionId} | Commit or cancel the specified transaction |
| *DataTransferApi*        | [**CreatePortTransaction**](Docs/DataTransferApi.md#createPortTransaction) | **POST** /data-transfer/{portType}/{portId}/transactions | Create a transaction to the specified output port or input port |
| *DataTransferApi*        | [**ExtendInputPortTransactionTTL**](Docs/DataTransferApi.md#extendInputPortTransactionTTL) | **PUT** /data-transfer/input-ports/{portId}/transactions/{transactionId} | Extend transaction TTL                   |
| *DataTransferApi*        | [**ExtendOutputPortTransactionTTL**](Docs/DataTransferApi.md#extendOutputPortTransactionTTL) | **PUT** /data-transfer/output-ports/{portId}/transactions/{transactionId} | Extend transaction TTL                   |
| *DataTransferApi*        | [**ReceiveFlowFiles**](Docs/DataTransferApi.md#receiveFlowFiles) | **POST** /data-transfer/input-ports/{portId}/transactions/{transactionId}/flow-files | Transfer flow files to the input port    |
| *DataTransferApi*        | [**TransferFlowFiles**](Docs/DataTransferApi.md#transferFlowFiles) | **GET** /data-transfer/output-ports/{portId}/transactions/{transactionId}/flow-files | Transfer flow files from the output port |
| *FlowApi*                | [**GenerateClientId**](Docs/FlowApi.md#generateClientId) | **GET** /flow/client-id                  | Generates a client id.                   |
| *FlowApi*                | [**GetAboutInfo**](Docs/FlowApi.md#getAboutInfo) | **GET** /flow/about                      | Retrieves details about this NiFi to put in the About dialog |
| *FlowApi*                | [**GetAction**](Docs/FlowApi.md#getAction) | **GET** /flow/history/{id}               | Gets an action                           |
| *FlowApi*                | [**GetBanners**](Docs/FlowApi.md#getBanners) | **GET** /flow/banners                    | Retrieves the banners for this NiFi      |
| *FlowApi*                | [**GetBulletinBoard**](Docs/FlowApi.md#getBulletinBoard) | **GET** /flow/bulletin-board             | Gets current bulletins                   |
| *FlowApi*                | [**GetBulletins**](Docs/FlowApi.md#getBulletins) | **GET** /flow/controller/bulletins       | Retrieves Controller level bulletins     |
| *FlowApi*                | [**GetClusterSummary**](Docs/FlowApi.md#getClusterSummary) | **GET** /flow/cluster/summary            | The cluster summary for this NiFi        |
| *FlowApi*                | [**GetComponentHistory**](Docs/FlowApi.md#getComponentHistory) | **GET** /flow/history/components/{componentId} | Gets configuration history for a component |
| *FlowApi*                | [**GetConnectionStatus**](Docs/FlowApi.md#getConnectionStatus) | **GET** /flow/connections/{id}/status    | Gets status for a connection             |
| *FlowApi*                | [**GetConnectionStatusHistory**](Docs/FlowApi.md#getConnectionStatusHistory) | **GET** /flow/connections/{id}/status/history | Gets the status history for a connection |
| *FlowApi*                | [**GetControllerServiceTypes**](Docs/FlowApi.md#getControllerServiceTypes) | **GET** /flow/controller-service-types   | Retrieves the types of controller services that this NiFi supports |
| *FlowApi*                | [**GetControllerServicesFromController**](Docs/FlowApi.md#getControllerServicesFromController) | **GET** /flow/controller/controller-services | Gets all controller services             |
| *FlowApi*                | [**GetControllerServicesFromGroup**](Docs/FlowApi.md#getControllerServicesFromGroup) | **GET** /flow/process-groups/{id}/controller-services | Gets all controller services             |
| *FlowApi*                | [**GetControllerStatus**](Docs/FlowApi.md#getControllerStatus) | **GET** /flow/status                     | Gets the current status of this NiFi     |
| *FlowApi*                | [**GetCurrentUser**](Docs/FlowApi.md#getCurrentUser) | **GET** /flow/current-user               | Retrieves the user identity of the user making the request |
| *FlowApi*                | [**GetFlow**](Docs/FlowApi.md#getFlow)   | **GET** /flow/process-groups/{id}        | Gets a process group                     |
| *FlowApi*                | [**GetFlowConfig**](Docs/FlowApi.md#getFlowConfig) | **GET** /flow/config                     | Retrieves the configuration for this NiFi flow |
| *FlowApi*                | [**GetInputPortStatus**](Docs/FlowApi.md#getInputPortStatus) | **GET** /flow/input-ports/{id}/status    | Gets status for an input port            |
| *FlowApi*                | [**GetOutputPortStatus**](Docs/FlowApi.md#getOutputPortStatus) | **GET** /flow/output-ports/{id}/status   | Gets status for an output port           |
| *FlowApi*                | [**GetPrioritizers**](Docs/FlowApi.md#getPrioritizers) | **GET** /flow/prioritizers               | Retrieves the types of prioritizers that this NiFi supports |
| *FlowApi*                | [**GetProcessGroupStatus**](Docs/FlowApi.md#getProcessGroupStatus) | **GET** /flow/process-groups/{id}/status | Gets the status for a process group      |
| *FlowApi*                | [**GetProcessGroupStatusHistory**](Docs/FlowApi.md#getProcessGroupStatusHistory) | **GET** /flow/process-groups/{id}/status/history | Gets status history for a remote process group |
| *FlowApi*                | [**GetProcessorStatus**](Docs/FlowApi.md#getProcessorStatus) | **GET** /flow/processors/{id}/status     | Gets status for a processor              |
| *FlowApi*                | [**GetProcessorStatusHistory**](Docs/FlowApi.md#getProcessorStatusHistory) | **GET** /flow/processors/{id}/status/history | Gets status history for a processor      |
| *FlowApi*                | [**GetProcessorTypes**](Docs/FlowApi.md#getProcessorTypes) | **GET** /flow/processor-types            | Retrieves the types of processors that this NiFi supports |
| *FlowApi*                | [**GetRemoteProcessGroupStatus**](Docs/FlowApi.md#getRemoteProcessGroupStatus) | **GET** /flow/remote-process-groups/{id}/status | Gets status for a remote process group   |
| *FlowApi*                | [**GetRemoteProcessGroupStatusHistory**](Docs/FlowApi.md#getRemoteProcessGroupStatusHistory) | **GET** /flow/remote-process-groups/{id}/status/history | Gets the status history                  |
| *FlowApi*                | [**GetReportingTaskTypes**](Docs/FlowApi.md#getReportingTaskTypes) | **GET** /flow/reporting-task-types       | Retrieves the types of reporting tasks that this NiFi supports |
| *FlowApi*                | [**GetReportingTasks**](Docs/FlowApi.md#getReportingTasks) | **GET** /flow/reporting-tasks            | Gets all reporting tasks                 |
| *FlowApi*                | [**GetTemplates**](Docs/FlowApi.md#getTemplates) | **GET** /flow/templates                  | Gets all templates                       |
| *FlowApi*                | [**QueryHistory**](Docs/FlowApi.md#queryHistory) | **GET** /flow/history                    | Gets configuration history               |
| *FlowApi*                | [**ScheduleComponents**](Docs/FlowApi.md#scheduleComponents) | **PUT** /flow/process-groups/{id}        | Schedule or unschedule comopnents in the specified Process Group. |
| *FlowApi*                | [**SearchCluster**](Docs/FlowApi.md#searchCluster) | **GET** /flow/cluster/search-results     | Searches the cluster for a node with the specified address |
| *FlowApi*                | [**SearchFlow**](Docs/FlowApi.md#searchFlow) | **GET** /flow/search-results             | Performs a search against this NiFi using the specified search term |
| *FlowfileQueuesApi*      | [**CreateDropRequest**](Docs/FlowfileQueuesApi.md#createDropRequest) | **POST** /flowfile-queues/{id}/drop-requests | Creates a request to drop the contents of the queue in this connection. |
| *FlowfileQueuesApi*      | [**CreateFlowFileListing**](Docs/FlowfileQueuesApi.md#createFlowFileListing) | **POST** /flowfile-queues/{id}/listing-requests | Lists the contents of the queue in this connection. |
| *FlowfileQueuesApi*      | [**DeleteListingRequest**](Docs/FlowfileQueuesApi.md#deleteListingRequest) | **DELETE** /flowfile-queues/{id}/listing-requests/{listing-request-id} | Cancels and/or removes a request to list the contents of this connection. |
| *FlowfileQueuesApi*      | [**DownloadFlowFileContent**](Docs/FlowfileQueuesApi.md#downloadFlowFileContent) | **GET** /flowfile-queues/{id}/flowfiles/{flowfile-uuid}/content | Gets the content for a FlowFile in a Connection. |
| *FlowfileQueuesApi*      | [**GetDropRequest**](Docs/FlowfileQueuesApi.md#getDropRequest) | **GET** /flowfile-queues/{id}/drop-requests/{drop-request-id} | Gets the current status of a drop request for the specified connection. |
| *FlowfileQueuesApi*      | [**GetFlowFile**](Docs/FlowfileQueuesApi.md#getFlowFile) | **GET** /flowfile-queues/{id}/flowfiles/{flowfile-uuid} | Gets a FlowFile from a Connection.       |
| *FlowfileQueuesApi*      | [**GetListingRequest**](Docs/FlowfileQueuesApi.md#getListingRequest) | **GET** /flowfile-queues/{id}/listing-requests/{listing-request-id} | Gets the current status of a listing request for the specified connection. |
| *FlowfileQueuesApi*      | [**RemoveDropRequest**](Docs/FlowfileQueuesApi.md#removeDropRequest) | **DELETE** /flowfile-queues/{id}/drop-requests/{drop-request-id} | Cancels and/or removes a request to drop the contents of this connection. |
| *FunnelApi*              | [**GetFunnel**](Docs/FunnelApi.md#getFunnel) | **GET** /funnels/{id}                    | Gets a funnel                            |
| *FunnelApi*              | [**RemoveFunnel**](Docs/FunnelApi.md#removeFunnel) | **DELETE** /funnels/{id}                 | Deletes a funnel                         |
| *FunnelApi*              | [**UpdateFunnel**](Docs/FunnelApi.md#updateFunnel) | **PUT** /funnels/{id}                    | Updates a funnel                         |
| *InputPortsApi*          | [**GetInputPort**](Docs/InputPortsApi.md#getInputPort) | **GET** /input-ports/{id}                | Gets an input port                       |
| *InputPortsApi*          | [**RemoveInputPort**](Docs/InputPortsApi.md#removeInputPort) | **DELETE** /input-ports/{id}             | Deletes an input port                    |
| *InputPortsApi*          | [**UpdateInputPort**](Docs/InputPortsApi.md#updateInputPort) | **PUT** /input-ports/{id}                | Updates an input port                    |
| *LabelsApi*              | [**GetLabel**](Docs/LabelsApi.md#getLabel) | **GET** /labels/{id}                     | Gets a label                             |
| *LabelsApi*              | [**RemoveLabel**](Docs/LabelsApi.md#removeLabel) | **DELETE** /labels/{id}                  | Deletes a label                          |
| *LabelsApi*              | [**UpdateLabel**](Docs/LabelsApi.md#updateLabel) | **PUT** /labels/{id}                     | Updates a label                          |
| *OutputPortsApi*         | [**GetOutputPort**](Docs/OutputPortsApi.md#getOutputPort) | **GET** /output-ports/{id}               | Gets an output port                      |
| *OutputPortsApi*         | [**RemoveOutputPort**](Docs/OutputPortsApi.md#removeOutputPort) | **DELETE** /output-ports/{id}            | Deletes an output port                   |
| *OutputPortsApi*         | [**UpdateOutputPort**](Docs/OutputPortsApi.md#updateOutputPort) | **PUT** /output-ports/{id}               | Updates an output port                   |
| *PoliciesApi*            | [**RreateAccessPolicy**](Docs/PoliciesApi.md#createAccessPolicy) | **POST** /policies                       | Creates an access policy                 |
| *PoliciesApi*            | [**GetAccessPolicy**](Docs/PoliciesApi.md#getAccessPolicy) | **GET** /policies/{id}                   | Gets an access policy                    |
| *PoliciesApi*            | [**GetAccessPolicyForResource**](Docs/PoliciesApi.md#getAccessPolicyForResource) | **GET** /policies/{action}/{resource}    | Gets an access policy for the specified action and resource |
| *PoliciesApi*            | [**RemoveAccessPolicy**](Docs/PoliciesApi.md#removeAccessPolicy) | **DELETE** /policies/{id}                | Deletes an access policy                 |
| *PoliciesApi*            | [**UpdateAccessPolicy**](Docs/PoliciesApi.md#updateAccessPolicy) | **PUT** /policies/{id}                   | Updates a access policy                  |
| *ProcessGroupsApi*       | [**CopySnippet**](Docs/ProcessGroupsApi.md#copySnippet) | **POST** /process-groups/{id}/snippet-instance | Copies a snippet and discards it.        |
| *ProcessGroupsApi*       | [**CreateConnection**](Docs/ProcessGroupsApi.md#createConnection) | **POST** /process-groups/{id}/connections | Creates a connection                     |
| *ProcessGroupsApi*       | [**CreateControllerService**](Docs/ProcessGroupsApi.md#createControllerService) | **POST** /process-groups/{id}/controller-services | Creates a new controller service         |
| *ProcessGroupsApi*       | [**CreateFunnel**](Docs/ProcessGroupsApi.md#createFunnel) | **POST** /process-groups/{id}/funnels    | Creates a funnel                         |
| *ProcessGroupsApi*       | [**CreateInputPort**](Docs/ProcessGroupsApi.md#createInputPort) | **POST** /process-groups/{id}/input-ports | Creates an input port                    |
| *ProcessGroupsApi*       | [**CreateLabel**](Docs/ProcessGroupsApi.md#createLabel) | **POST** /process-groups/{id}/labels     | Creates a label                          |
| *ProcessGroupsApi*       | [**CreateOutputPort**](Docs/ProcessGroupsApi.md#createOutputPort) | **POST** /process-groups/{id}/output-ports | Creates an output port                   |
| *ProcessGroupsApi*       | [**CreateProcessGroup**](Docs/ProcessGroupsApi.md#createProcessGroup) | **POST** /process-groups/{id}/process-groups | Creates a process group                  |
| *ProcessGroupsApi*       | [**CreateProcessor**](Docs/ProcessGroupsApi.md#createProcessor) | **POST** /process-groups/{id}/processors | Creates a new processor                  |
| *ProcessGroupsApi*       | [**CreateRemoteProcessGroup**](Docs/ProcessGroupsApi.md#createRemoteProcessGroup) | **POST** /process-groups/{id}/remote-process-groups | Creates a new process group              |
| *ProcessGroupsApi*       | [**CreateTemplate**](Docs/ProcessGroupsApi.md#createTemplate) | **POST** /process-groups/{id}/templates  | Creates a template and discards the specified snippet. |
| *ProcessGroupsApi*       | [**GetConnections**](Docs/ProcessGroupsApi.md#getConnections) | **GET** /process-groups/{id}/connections | Gets all connections                     |
| *ProcessGroupsApi*       | [**GetFunnels**](Docs/ProcessGroupsApi.md#getFunnels) | **GET** /process-groups/{id}/funnels     | Gets all funnels                         |
| *ProcessGroupsApi*       | [**GetInputPorts**](Docs/ProcessGroupsApi.md#getInputPorts) | **GET** /process-groups/{id}/input-ports | Gets all input ports                     |
| *ProcessGroupsApi*       | [**GetLabels**](Docs/ProcessGroupsApi.md#getLabels) | **GET** /process-groups/{id}/labels      | Gets all labels                          |
| *ProcessGroupsApi*       | [**GetOutputPorts**](Docs/ProcessGroupsApi.md#getOutputPorts) | **GET** /process-groups/{id}/output-ports | Gets all output ports                    |
| *ProcessGroupsApi*       | [**GetProcessGroup**](Docs/ProcessGroupsApi.md#getProcessGroup) | **GET** /process-groups/{id}             | Gets a process group                     |
| *ProcessGroupsApi*       | [**GetProcessGroups**](Docs/ProcessGroupsApi.md#getProcessGroups) | **GET** /process-groups/{id}/process-groups | Gets all process groups                  |
| *ProcessGroupsApi*       | [**GetProcessors**](Docs/ProcessGroupsApi.md#getProcessors) | **GET** /process-groups/{id}/processors  | Gets all processors                      |
| *ProcessGroupsApi*       | [**GetRemoteProcessGroups**](Docs/ProcessGroupsApi.md#getRemoteProcessGroups) | **GET** /process-groups/{id}/remote-process-groups | Gets all remote process groups           |
| *ProcessGroupsApi*       | [**ImportTemplate**](Docs/ProcessGroupsApi.md#importTemplate) | **POST** /process-groups/{id}/templates/import | Imports a template                       |
| *ProcessGroupsApi*       | [**InstantiateTemplate**](Docs/ProcessGroupsApi.md#instantiateTemplate) | **POST** /process-groups/{id}/template-instance | Instantiates a template                  |
| *ProcessGroupsApi*       | [**RemoveProcessGroup**](Docs/ProcessGroupsApi.md#removeProcessGroup) | **DELETE** /process-groups/{id}          | Deletes a process group                  |
| *ProcessGroupsApi*       | [**UpdateProcessGroup**](Docs/ProcessGroupsApi.md#updateProcessGroup) | **PUT** /process-groups/{id}             | Updates a process group                  |
| *ProcessGroupsApi*       | [**UploadTemplate**](Docs/ProcessGroupsApi.md#uploadTemplate) | **POST** /process-groups/{id}/templates/upload | Uploads a template                       |
| *ProcessorsApi*          | [**ClearState**](Docs/ProcessorsApi.md#clearState) | **POST** /processors/{id}/state/clear-requests | Clears the state for a processor         |
| *ProcessorsApi*          | [**DeleteProcessor**](Docs/ProcessorsApi.md#deleteProcessor) | **DELETE** /processors/{id}              | Deletes a processor                      |
| *ProcessorsApi*          | [**GetProcessor**](Docs/ProcessorsApi.md#getProcessor) | **GET** /processors/{id}                 | Gets a processor                         |
| *ProcessorsApi*          | [**GetPropertyDescriptor**](Docs/ProcessorsApi.md#getPropertyDescriptor) | **GET** /processors/{id}/descriptors     | Gets the descriptor for a processor property |
| *ProcessorsApi*          | [**GetState**](Docs/ProcessorsApi.md#getState) | **GET** /processors/{id}/state           | Gets the state for a processor           |
| *ProcessorsApi*          | [**UpdateProcessor**](Docs/ProcessorsApi.md#updateProcessor) | **PUT** /processors/{id}                 | Updates a processor                      |
| *ProvenanceApi*          | [**DeleteLineage**](Docs/ProvenanceApi.md#deleteLineage) | **DELETE** /provenance/lineage/{id}      | Deletes a lineage query                  |
| *ProvenanceApi*          | [**DeleteProvenance**](Docs/ProvenanceApi.md#deleteProvenance) | **DELETE** /provenance/{id}              | Deletes a provenance query               |
| *ProvenanceApi*          | [**GetLineage**](Docs/ProvenanceApi.md#getLineage) | **GET** /provenance/lineage/{id}         | Gets a lineage query                     |
| *ProvenanceApi*          | [**GetProvenance**](Docs/ProvenanceApi.md#getProvenance) | **GET** /provenance/{id}                 | Gets a provenance query                  |
| *ProvenanceApi*          | [**GetSearchOptions**](Docs/ProvenanceApi.md#getSearchOptions) | **GET** /provenance/search-options       | Gets the searchable attributes for provenance events |
| *ProvenanceApi*          | [**SubmitLineageRequest**](Docs/ProvenanceApi.md#submitLineageRequest) | **POST** /provenance/lineage             | Submits a lineage query                  |
| *ProvenanceApi*          | [**SubmitProvenanceRequest**](Docs/ProvenanceApi.md#submitProvenanceRequest) | **POST** /provenance                     | Submits a provenance query               |
| *ProvenanceEventsApi*    | [**GetInputContent**](Docs/ProvenanceEventsApi.md#getInputContent) | **GET** /provenance-events/{id}/content/input | Gets the input content for a provenance event |
| *ProvenanceEventsApi*    | [**GetOutputContent**](Docs/ProvenanceEventsApi.md#getOutputContent) | **GET** /provenance-events/{id}/content/output | Gets the output content for a provenance event |
| *ProvenanceEventsApi*    | [**GetProvenanceEvent**](Docs/ProvenanceEventsApi.md#getProvenanceEvent) | **GET** /provenance-events/{id}          | Gets a provenance event                  |
| *ProvenanceEventsApi*    | [**SubmitReplay**](Docs/ProvenanceEventsApi.md#submitReplay) | **POST** /provenance-events/replays      | Replays content from a provenance event  |
| *RemoteProcessGroupsApi* | [**GetRemoteProcessGroup**](Docs/RemoteProcessGroupsApi.md#getRemoteProcessGroup) | **GET** /remote-process-groups/{id}      | Gets a remote process group              |
| *RemoteProcessGroupsApi* | [**RemoveRemoteProcessGroup**](Docs/RemoteProcessGroupsApi.md#removeRemoteProcessGroup) | **DELETE** /remote-process-groups/{id}   | Deletes a remote process group           |
| *RemoteProcessGroupsApi* | [**UpdateRemoteProcessGroup**](Docs/RemoteProcessGroupsApi.md#updateRemoteProcessGroup) | **PUT** /remote-process-groups/{id}      | Updates a remote process group           |
| *RemoteProcessGroupsApi* | [**UpdateRemoteProcessGroupInputPort**](Docs/RemoteProcessGroupsApi.md#updateRemoteProcessGroupInputPort) | **PUT** /remote-process-groups/{id}/input-ports/{port-id} | Updates a remote port                    |
| *RemoteProcessGroupsApi* | [**UpdateRemoteProcessGroupOutputPort**](Docs/RemoteProcessGroupsApi.md#updateRemoteProcessGroupOutputPort) | **PUT** /remote-process-groups/{id}/output-ports/{port-id} | Updates a remote port                    |
| *ReportingTasksApi*      | [**ClearState**](Docs/ReportingTasksApi.md#clearState) | **POST** /reporting-tasks/{id}/state/clear-requests | Clears the state for a reporting task    |
| *ReportingTasksApi*      | [**GetPropertyDescriptor**](Docs/ReportingTasksApi.md#getPropertyDescriptor) | **GET** /reporting-tasks/{id}/descriptors | Gets a reporting task property descriptor |
| *ReportingTasksApi*      | [**GetReportingTask**](Docs/ReportingTasksApi.md#getReportingTask) | **GET** /reporting-tasks/{id}            | Gets a reporting task                    |
| *ReportingTasksApi*      | [**GetState**](Docs/ReportingTasksApi.md#getState) | **GET** /reporting-tasks/{id}/state      | Gets the state for a reporting task      |
| *ReportingTasksApi*      | [**RemoveReportingTask**](Docs/ReportingTasksApi.md#removeReportingTask) | **DELETE** /reporting-tasks/{id}         | Deletes a reporting task                 |
| *ReportingTasksApi*      | [**UpdateReportingTask**](Docs/ReportingTasksApi.md#updateReportingTask) | **PUT** /reporting-tasks/{id}            | Updates a reporting task                 |
| *ResourcesApi*           | [**GetResources**](Docs/ResourcesApi.md#getResources) | **GET** /resources                       | Gets the available resources that support access/authorization policies |
| *SiteToSiteApi*          | [**GetPeers**](Docs/SiteToSiteApi.md#getPeers) | **GET** /site-to-site/peers              | Returns the available Peers and its status of this NiFi |
| *SiteToSiteApi*          | [**GetSiteToSiteDetails**](Docs/SiteToSiteApi.md#getSiteToSiteDetails) | **GET** /site-to-site                    | Returns the details about this NiFi necessary to communicate via site to site |
| *SnippetsApi*            | [**CreateSnippet**](Docs/SnippetsApi.md#createSnippet) | **POST** /snippets                       | Creates a snippet. The snippet will be automatically discarded if not used in a subsequent request after 1 minute. |
| *SnippetsApi*            | [**DeleteSnippet**](Docs/SnippetsApi.md#deleteSnippet) | **DELETE** /snippets/{id}                | Deletes the components in a snippet and discards the snippet |
| *SnippetsApi*            | [**UpdateSnippet**](Docs/SnippetsApi.md#updateSnippet) | **PUT** /snippets/{id}                   | Move&#39;s the components in this Snippet into a new Process Group and discards the snippet |
| *SystemDiagnosticsApi*   | [**GetSystemDiagnostics**](Docs/SystemDiagnosticsApi.md#getSystemDiagnostics) | **GET** /system-diagnostics              | Gets the diagnostics for the system NiFi is running on |
| *TemplatesApi*           | [**ExportTemplate**](Docs/TemplatesApi.md#exportTemplate) | **GET** /templates/{id}/download         | Exports a template                       |
| *TemplatesApi*           | [**RemoveTemplate**](Docs/TemplatesApi.md#removeTemplate) | **DELETE** /templates/{id}               | Deletes a template                       |
| *TenantsApi*             | [**CreateUser**](Docs/TenantsApi.md#createUser) | **POST** /tenants/users                  | Creates a user                           |
| *TenantsApi*             | [**CreateUserGroup**](Docs/TenantsApi.md#createUserGroup) | **POST** /tenants/user-groups            | Creates a user group                     |
| *TenantsApi*             | [**GetUser**](Docs/TenantsApi.md#getUser) | **GET** /tenants/users/{id}              | Gets a user                              |
| *TenantsApi*             | [**GetUserGroup**](Docs/TenantsApi.md#getUserGroup) | **GET** /tenants/user-groups/{id}        | Gets a user group                        |
| *TenantsApi*             | [**GetUserGroups**](Docs/TenantsApi.md#getUserGroups) | **GET** /tenants/user-groups             | Gets all user groups                     |
| *TenantsApi*             | [**GetUsers**](Docs/TenantsApi.md#getUsers) | **GET** /tenants/users                   | Gets all users                           |
| *TenantsApi*             | [**RemoveUser**](Docs/TenantsApi.md#removeUser) | **DELETE** /tenants/users/{id}           | Deletes a user                           |
| *TenantsApi*             | [**RemoveUserGroup**](Docs/TenantsApi.md#removeUserGroup) | **DELETE** /tenants/user-groups/{id}     | Deletes a user group                     |
| *TenantsApi*             | [**SearchCluster**](Docs/TenantsApi.md#searchCluster) | **GET** /tenants/search-results          | Searches for a tenant with the specified identity |
| *TenantsApi*             | [**UpdateUser**](Docs/TenantsApi.md#updateUser) | **PUT** /tenants/users/{id}              | Updates a user                           |
| *TenantsApi*             | [**UpdateUserGroup**](Docs/TenantsApi.md#updateUserGroup) | **PUT** /tenants/user-groups/{id}        | Updates a user group                     |

## Documentation for Models

- [AboutDTO](Docs/AboutDTO.md)
- [AboutEntity](Docs/AboutEntity.md)
- [AccessConfigurationDTO](Docs/AccessConfigurationDTO.md)
- [AccessConfigurationEntity](Docs/AccessConfigurationEntity.md)
- [AccessPolicyDTO](Docs/AccessPolicyDTO.md)
- [AccessPolicyEntity](Docs/AccessPolicyEntity.md)
- [AccessPolicySummaryDTO](Docs/AccessPolicySummaryDTO.md)
- [AccessPolicySummaryEntity](Docs/AccessPolicySummaryEntity.md)
- [AccessStatusDTO](Docs/AccessStatusDTO.md)
- [AccessStatusEntity](Docs/AccessStatusEntity.md)
- [ActionDTO](Docs/ActionDTO.md)
- [ActionDetailsDTO](Docs/ActionDetailsDTO.md)
- [ActionEntity](Docs/ActionEntity.md)
- [AllowableValueDTO](Docs/AllowableValueDTO.md)
- [AllowableValueEntity](Docs/AllowableValueEntity.md)
- [AttributeDTO](Docs/AttributeDTO.md)
- [BannerDTO](Docs/BannerDTO.md)
- [BannerEntity](Docs/BannerEntity.md)
- [BatchSettingsDTO](Docs/BatchSettingsDTO.md)
- [BulletinBoardDTO](Docs/BulletinBoardDTO.md)
- [BulletinBoardEntity](Docs/BulletinBoardEntity.md)
- [BulletinDTO](Docs/BulletinDTO.md)
- [BulletinEntity](Docs/BulletinEntity.md)
- [BundleDTO](Docs/BundleDTO.md)
- [ClusteSummaryEntity](Docs/ClusteSummaryEntity.md)
- [ClusterDTO](Docs/ClusterDTO.md)
- [ClusterEntity](Docs/ClusterEntity.md)
- [ClusterSearchResultsEntity](Docs/ClusterSearchResultsEntity.md)
- [ClusterSummaryDTO](Docs/ClusterSummaryDTO.md)
- [ComponentDetailsDTO](Docs/ComponentDetailsDTO.md)
- [ComponentHistoryDTO](Docs/ComponentHistoryDTO.md)
- [ComponentHistoryEntity](Docs/ComponentHistoryEntity.md)
- [ComponentReferenceDTO](Docs/ComponentReferenceDTO.md)
- [ComponentReferenceEntity](Docs/ComponentReferenceEntity.md)
- [ComponentSearchResultDTO](Docs/ComponentSearchResultDTO.md)
- [ComponentStateDTO](Docs/ComponentStateDTO.md)
- [ConnectableDTO](Docs/ConnectableDTO.md)
- [ConnectionDTO](Docs/ConnectionDTO.md)
- [ConnectionEntity](Docs/ConnectionEntity.md)
- [ConnectionStatusDTO](Docs/ConnectionStatusDTO.md)
- [ConnectionStatusEntity](Docs/ConnectionStatusEntity.md)
- [ConnectionStatusSnapshotDTO](Docs/ConnectionStatusSnapshotDTO.md)
- [ConnectionStatusSnapshotEntity](Docs/ConnectionStatusSnapshotEntity.md)
- [ConnectionsEntity](Docs/ConnectionsEntity.md)
- [ControllerBulletinsEntity](Docs/ControllerBulletinsEntity.md)
- [ControllerConfigurationDTO](Docs/ControllerConfigurationDTO.md)
- [ControllerConfigurationEntity](Docs/ControllerConfigurationEntity.md)
- [ControllerDTO](Docs/ControllerDTO.md)
- [ControllerEntity](Docs/ControllerEntity.md)
- [ControllerServiceApiDTO](Docs/ControllerServiceApiDTO.md)
- [ControllerServiceDTO](Docs/ControllerServiceDTO.md)
- [ControllerServiceEntity](Docs/ControllerServiceEntity.md)
- [ControllerServiceReferencingComponentDTO](Docs/ControllerServiceReferencingComponentDTO.md)
- [ControllerServiceReferencingComponentEntity](Docs/ControllerServiceReferencingComponentEntity.md)
- [ControllerServiceReferencingComponentsEntity](Docs/ControllerServiceReferencingComponentsEntity.md)
- [ControllerServiceTypesEntity](Docs/ControllerServiceTypesEntity.md)
- [ControllerServicesEntity](Docs/ControllerServicesEntity.md)
- [ControllerStatusDTO](Docs/ControllerStatusDTO.md)
- [ControllerStatusEntity](Docs/ControllerStatusEntity.md)
- [CopySnippetRequestEntity](Docs/CopySnippetRequestEntity.md)
- [CounterDTO](Docs/CounterDTO.md)
- [CounterEntity](Docs/CounterEntity.md)
- [CountersDTO](Docs/CountersDTO.md)
- [CountersEntity](Docs/CountersEntity.md)
- [CountersSnapshotDTO](Docs/CountersSnapshotDTO.md)
- [CreateTemplateRequestEntity](Docs/CreateTemplateRequestEntity.md)
- [CurrentUserEntity](Docs/CurrentUserEntity.md)
- [DimensionsDTO](Docs/DimensionsDTO.md)
- [DocumentedTypeDTO](Docs/DocumentedTypeDTO.md)
- [DropRequestDTO](Docs/DropRequestDTO.md)
- [DropRequestEntity](Docs/DropRequestEntity.md)
- [FlowBreadcrumbDTO](Docs/FlowBreadcrumbDTO.md)
- [FlowBreadcrumbEntity](Docs/FlowBreadcrumbEntity.md)
- [FlowConfigurationDTO](Docs/FlowConfigurationDTO.md)
- [FlowConfigurationEntity](Docs/FlowConfigurationEntity.md)
- [FlowDTO](Docs/FlowDTO.md)
- [FlowEntity](Docs/FlowEntity.md)
- [FlowFileSummaryDTO](Docs/FlowFileSummaryDTO.md)
- [FlowSnippetDTO](Docs/FlowSnippetDTO.md)
- [FlowSnippetEntity](Docs/FlowSnippetEntity.md)
- [FunnelDTO](Docs/FunnelDTO.md)
- [FunnelEntity](Docs/FunnelEntity.md)
- [FunnelsEntity](Docs/FunnelsEntity.md)
- [GarbageCollectionDTO](Docs/GarbageCollectionDTO.md)
- [HistoryDTO](Docs/HistoryDTO.md)
- [HistoryEntity](Docs/HistoryEntity.md)
- [InputPortsEntity](Docs/InputPortsEntity.md)
- [InstantiateTemplateRequestEntity](Docs/InstantiateTemplateRequestEntity.md)
- [LabelDTO](Docs/LabelDTO.md)
- [LabelEntity](Docs/LabelEntity.md)
- [LabelsEntity](Docs/LabelsEntity.md)
- [LineageDTO](Docs/LineageDTO.md)
- [LineageEntity](Docs/LineageEntity.md)
- [LineageRequestDTO](Docs/LineageRequestDTO.md)
- [LineageResultsDTO](Docs/LineageResultsDTO.md)
- [ListingRequestDTO](Docs/ListingRequestDTO.md)
- [ListingRequestEntity](Docs/ListingRequestEntity.md)
- [NodeConnectionStatusSnapshotDTO](Docs/NodeConnectionStatusSnapshotDTO.md)
- [NodeCountersSnapshotDTO](Docs/NodeCountersSnapshotDTO.md)
- [NodeDTO](Docs/NodeDTO.md)
- [NodeEntity](Docs/NodeEntity.md)
- [NodeEventDTO](Docs/NodeEventDTO.md)
- [NodePortStatusSnapshotDTO](Docs/NodePortStatusSnapshotDTO.md)
- [NodeProcessGroupStatusSnapshotDTO](Docs/NodeProcessGroupStatusSnapshotDTO.md)
- [NodeProcessorStatusSnapshotDTO](Docs/NodeProcessorStatusSnapshotDTO.md)
- [NodeRemoteProcessGroupStatusSnapshotDTO](Docs/NodeRemoteProcessGroupStatusSnapshotDTO.md)
- [NodeSearchResultDTO](Docs/NodeSearchResultDTO.md)
- [NodeStatusSnapshotsDTO](Docs/NodeStatusSnapshotsDTO.md)
- [NodeSystemDiagnosticsSnapshotDTO](Docs/NodeSystemDiagnosticsSnapshotDTO.md)
- [OutputPortsEntity](Docs/OutputPortsEntity.md)
- [PeerDTO](Docs/PeerDTO.md)
- [PeersEntity](Docs/PeersEntity.md)
- [PermissionsDTO](Docs/PermissionsDTO.md)
- [PortDTO](Docs/PortDTO.md)
- [PortEntity](Docs/PortEntity.md)
- [PortStatusDTO](Docs/PortStatusDTO.md)
- [PortStatusEntity](Docs/PortStatusEntity.md)
- [PortStatusSnapshotDTO](Docs/PortStatusSnapshotDTO.md)
- [PortStatusSnapshotEntity](Docs/PortStatusSnapshotEntity.md)
- [PositionDTO](Docs/PositionDTO.md)
- [PreviousValueDTO](Docs/PreviousValueDTO.md)
- [PrioritizerTypesEntity](Docs/PrioritizerTypesEntity.md)
- [ProcessGroupDTO](Docs/ProcessGroupDTO.md)
- [ProcessGroupEntity](Docs/ProcessGroupEntity.md)
- [ProcessGroupFlowDTO](Docs/ProcessGroupFlowDTO.md)
- [ProcessGroupFlowEntity](Docs/ProcessGroupFlowEntity.md)
- [ProcessGroupStatusDTO](Docs/ProcessGroupStatusDTO.md)
- [ProcessGroupStatusEntity](Docs/ProcessGroupStatusEntity.md)
- [ProcessGroupStatusSnapshotDTO](Docs/ProcessGroupStatusSnapshotDTO.md)
- [ProcessGroupStatusSnapshotEntity](Docs/ProcessGroupStatusSnapshotEntity.md)
- [ProcessorConfigDTO](Docs/ProcessorConfigDTO.md)
- [ProcessorDTO](Docs/ProcessorDTO.md)
- [ProcessorEntity](Docs/ProcessorEntity.md)
- [ProcessorStatusDTO](Docs/ProcessorStatusDTO.md)
- [ProcessorStatusEntity](Docs/ProcessorStatusEntity.md)
- [ProcessorStatusSnapshotDTO](Docs/ProcessorStatusSnapshotDTO.md)
- [ProcessorStatusSnapshotEntity](Docs/ProcessorStatusSnapshotEntity.md)
- [ProcessorTypesEntity](Docs/ProcessorTypesEntity.md)
- [ProcessorsEntity](Docs/ProcessorsEntity.md)
- [PropertyDescriptorDTO](Docs/PropertyDescriptorDTO.md)
- [PropertyDescriptorEntity](Docs/PropertyDescriptorEntity.md)
- [PropertyHistoryDTO](Docs/PropertyHistoryDTO.md)
- [ProvenanceDTO](Docs/ProvenanceDTO.md)
- [ProvenanceEntity](Docs/ProvenanceEntity.md)
- [ProvenanceEventDTO](Docs/ProvenanceEventDTO.md)
- [ProvenanceEventEntity](Docs/ProvenanceEventEntity.md)
- [ProvenanceLinkDTO](Docs/ProvenanceLinkDTO.md)
- [ProvenanceNodeDTO](Docs/ProvenanceNodeDTO.md)
- [ProvenanceOptionsDTO](Docs/ProvenanceOptionsDTO.md)
- [ProvenanceOptionsEntity](Docs/ProvenanceOptionsEntity.md)
- [ProvenanceRequestDTO](Docs/ProvenanceRequestDTO.md)
- [ProvenanceResultsDTO](Docs/ProvenanceResultsDTO.md)
- [ProvenanceSearchableFieldDTO](Docs/ProvenanceSearchableFieldDTO.md)
- [QueueSizeDTO](Docs/QueueSizeDTO.md)
- [RelationshipDTO](Docs/RelationshipDTO.md)
- [RemoteProcessGroupContentsDTO](Docs/RemoteProcessGroupContentsDTO.md)
- [RemoteProcessGroupDTO](Docs/RemoteProcessGroupDTO.md)
- [RemoteProcessGroupEntity](Docs/RemoteProcessGroupEntity.md)
- [RemoteProcessGroupPortDTO](Docs/RemoteProcessGroupPortDTO.md)
- [RemoteProcessGroupPortEntity](Docs/RemoteProcessGroupPortEntity.md)
- [RemoteProcessGroupStatusDTO](Docs/RemoteProcessGroupStatusDTO.md)
- [RemoteProcessGroupStatusSnapshotDTO](Docs/RemoteProcessGroupStatusSnapshotDTO.md)
- [RemoteProcessGroupStatusSnapshotEntity](Docs/RemoteProcessGroupStatusSnapshotEntity.md)
- [RemoteProcessGroupsEntity](Docs/RemoteProcessGroupsEntity.md)
- [ReportingTaskDTO](Docs/ReportingTaskDTO.md)
- [ReportingTaskEntity](Docs/ReportingTaskEntity.md)
- [ReportingTaskTypesEntity](Docs/ReportingTaskTypesEntity.md)
- [ReportingTasksEntity](Docs/ReportingTasksEntity.md)
- [ResourceDTO](Docs/ResourceDTO.md)
- [ResourcesEntity](Docs/ResourcesEntity.md)
- [RevisionDTO](Docs/RevisionDTO.md)
- [ScheduleComponentsEntity](Docs/ScheduleComponentsEntity.md)
- [SearchResultsDTO](Docs/SearchResultsDTO.md)
- [SearchResultsEntity](Docs/SearchResultsEntity.md)
- [SnippetDTO](Docs/SnippetDTO.md)
- [SnippetEntity](Docs/SnippetEntity.md)
- [StateEntryDTO](Docs/StateEntryDTO.md)
- [StateMapDTO](Docs/StateMapDTO.md)
- [StatusDescriptorDTO](Docs/StatusDescriptorDTO.md)
- [StatusHistoryDTO](Docs/StatusHistoryDTO.md)
- [StatusHistoryEntity](Docs/StatusHistoryEntity.md)
- [StatusSnapshotDTO](Docs/StatusSnapshotDTO.md)
- [StorageUsageDTO](Docs/StorageUsageDTO.md)
- [StreamingOutput](Docs/StreamingOutput.md)
- [SubmitReplayRequestEntity](Docs/SubmitReplayRequestEntity.md)
- [SystemDiagnosticsDTO](Docs/SystemDiagnosticsDTO.md)
- [SystemDiagnosticsEntity](Docs/SystemDiagnosticsEntity.md)
- [SystemDiagnosticsSnapshotDTO](Docs/SystemDiagnosticsSnapshotDTO.md)
- [TemplateDTO](Docs/TemplateDTO.md)
- [TemplateEntity](Docs/TemplateEntity.md)
- [TemplatesEntity](Docs/TemplatesEntity.md)
- [TenantDTO](Docs/TenantDTO.md)
- [TenantEntity](Docs/TenantEntity.md)
- [TenantsEntity](Docs/TenantsEntity.md)
- [TransactionResultEntity](Docs/TransactionResultEntity.md)
- [UpdateControllerServiceReferenceRequestEntity](Docs/UpdateControllerServiceReferenceRequestEntity.md)
- [UserDTO](Docs/UserDTO.md)
- [UserEntity](Docs/UserEntity.md)
- [UserGroupDTO](Docs/UserGroupDTO.md)
- [UserGroupEntity](Docs/UserGroupEntity.md)
- [UserGroupsEntity](Docs/UserGroupsEntity.md)
- [UsersEntity](Docs/UsersEntity.md)
- [VersionInfoDTO](Docs/VersionInfoDTO.md)

## Documentation for Authorization

Authentication schemes defined for the API:
### auth

- **Type**: OAuth
- **Flow**: implicit

## Author
Andre Mendonca
	
