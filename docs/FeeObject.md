# Org.OpenAPITools.Model.FeeObject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LagoId** | **Guid** |  | 
**LagoGroupId** | **Guid** |  | [optional] 
**LagoInvoiceId** | **Guid** |  | [optional] 
**LagoTrueUpFeeId** | **Guid** |  | [optional] 
**LagoTrueUpParentFeeId** | **Guid** |  | [optional] 
**ExternalSubscriptionId** | **string** |  | [optional] 
**AmountCents** | **int** |  | 
**AmountCurrency** | **string** |  | 
**VatAmountCents** | **int** |  | 
**VatAmountCurrency** | **string** |  | 
**Units** | **string** |  | 
**TotalAmountCents** | **int** |  | [optional] 
**TotalAmountCurrency** | **string** |  | [optional] 
**EventsCount** | **int** |  | [optional] 
**PayInAdvance** | **bool** |  | [optional] 
**Invoiceable** | **bool** |  | [optional] 
**FromDate** | **DateTime** |  | [optional] 
**ToDate** | **DateTime** |  | [optional] 
**PaymentStatus** | **string** |  | 
**CreatedAt** | **DateTime** |  | 
**SucceededAt** | **DateTime** |  | [optional] 
**FailedAt** | **DateTime** |  | [optional] 
**RefundedAt** | **DateTime** |  | [optional] 
**Item** | [**FeeObjectItem**](FeeObjectItem.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

