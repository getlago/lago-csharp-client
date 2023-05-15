
# Org.OpenAPITools.Model.CreditNoteObject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LagoId** | **Guid** |  | 
**SequentialId** | **int** |  | 
**Number** | **string** |  | 
**LagoInvoiceId** | **Guid** |  | 
**InvoiceNumber** | **string** |  | 
**IssuingDate** | **DateTime** |  | 
**CreditStatus** | **string** | Credit status | [optional] 
**RefundStatus** | **string** | Refund status | [optional] 
**Reason** | **string** | Reason | 
**Description** | **string** |  | [optional] 
**Currency** | **string** |  | 
**TotalAmountCents** | **int** |  | 
**TotalAmountCurrency** | **string** |  | 
**VatAmountCents** | **int** |  | 
**VatAmountCurrency** | **string** |  | 
**SubTotalVatExcludedAmountCents** | **int** |  | 
**SubTotalVatExcludedAmountCurrency** | **string** |  | 
**BalanceAmountCents** | **int** |  | 
**BalanceAmountCurrency** | **string** |  | 
**CreditAmountCents** | **int** |  | 
**CreditAmountCurrency** | **string** |  | 
**RefundAmountCents** | **int** |  | 
**RefundAmountCurrency** | **string** |  | 
**CouponsAdjustementAmountCents** | **int** |  | 
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | 
**FileUrl** | **string** |  | [optional] 
**Items** | [**List&lt;CreditNoteItemObject&gt;**](CreditNoteItemObject.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

