# IO.Swagger.Model.CreateSubscriptionPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the plan | 
**Description** | **string** | Description of the plan | [optional] 
**Vat** | **float?** | Optional vat for this plan. Account default is used if none given. | [optional] 
**Amount** | **int?** | Amount for the plan in the smallest unit for the account currency including VAT | 
**Quantity** | **int?** | Optional default quantity of the subscription plan product for new subscriptions. Default is 1. | [optional] 
**Prepaid** | **bool?** | Subscriptions can either be prepaid where an amount is paid in advance, or the opposite. This setting only relates to handling of pause scenarios. | [default to false]
**Handle** | **string** | Per account unique handle for the subscription plan. Max length 255 with allowable characters [a-zA-Z0-9_.-@]. | 
**DunningPlan** | **string** | Dunning plan handle | [optional] 
**RenewalReminderEmailDays** | **int?** | Optional renewal reminder email settings. Number of days before next billing to send a reminder email. | [optional] 
**TrialReminderEmailDays** | **int?** | Optional end of trial reminder email settings. Number of days before end of trial to send a reminder email. | [optional] 
**PartialPeriodHandling** | **string** | How to handle a potential initial partial billing period for fixed day scheduling. The options are to bill for a full period, bill prorated for the partial period, bill a zero amoumt, or not to consider the period before first fixed day a billing period. The default is to bill prorated. Options: &#x60;bill_full&#x60;, &#x60;bill_prorated&#x60;, &#x60;bill_zero_amount&#x60;, &#x60;no_bill&#x60;. | [optional] 
**AmountInclVat** | **bool?** | Whether the amount is including VAT. Default true. | [optional] [default to false]
**FixedCount** | **int?** | Fixed number of renewals for subscriptions using this plan. Equals the number of scheduled invoices. | [optional] 
**FixedLifeTimeUnit** | **string** | Time unit use for fixed life time | [optional] 
**FixedLifeTimeLength** | **int?** | Fixed life time length for subscriptions using this plan. E.g. 12 months. Subscriptions will cancel after the fixed life time and expire when the active billing cycle ends. | [optional] 
**TrialIntervalUnit** | **string** | Time unit for free trial period | [optional] 
**TrialIntervalLength** | **int?** | Free trial interval length. E.g. 1 month. | [optional] 
**IntervalLength** | **int?** | The length of intervals. E.g. every second month or every 14 days. | 
**ScheduleType** | **string** | Scheduling type, one of the following: &#x60;manual&#x60;, &#x60;daily&#x60;, &#x60;weekly_fixedday&#x60;, &#x60;month_startdate&#x60;, &#x60;month_fixedday&#x60;, &#x60;month_lastday&#x60;. See documentation for descriptions of the different types. | 
**ScheduleFixedDay** | **int?** | If a fixed day scheduling type is used a fixed day must be provided. For months the allowed value is 1-28 for weeks it is 1-7 | [optional] 
**BaseMonth** | **int?** | For fixed month schedule types the base month can be used to control which months are eligible for start of first billing period. The eligible months are calculated as &#x60;base_month + k * interval_length&#x60; up to 12. E.g. to use quaterly billing in the months jan-apr-jul-oct, base_month 1 and inrerval_length 3 can be used. If not defined the first fixed day will be used as start of first billing period. | [optional] 
**NoticePeriods** | **int?** | Optional number of notice periods for a cancel. The subscription will be cancelled for this number of full periods before expiring. Either from the cancellation date, or from the end of the the current period. See &#x60;notice_periods_after_current&#x60;. The default is to expire at the end of current period. | [optional] 
**NoticePeriodsAfterCurrent** | **bool?** | If notice periods is set, this option controls whether the number of full notice periods should start at the end of the current period, or run from cancellation date and result in a partial period with partial amount for the last period. The default is true. | [optional] [default to false]
**FixationPeriods** | **int?** | Optional number of fixation periods. Fixation periods will guarantee that a subscription will have this number of paid full periods before expiring after a cancel. | [optional] 
**FixationPeriodsFull** | **bool?** | If fixation periods are defined, and the subscription can have a partial prorated first period, this parameter controls if the the last period should be full, or partial to give exactly &#x60;fixation_periods&#x60; paid periods. Default is false. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

