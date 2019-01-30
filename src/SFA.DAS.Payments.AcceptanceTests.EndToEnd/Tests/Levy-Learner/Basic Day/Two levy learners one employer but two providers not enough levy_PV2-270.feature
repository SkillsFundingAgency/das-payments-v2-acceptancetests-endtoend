Feature: Two levy learners one employer but two providers and not enough levy PV2-270

Scenario Outline: Two levy learners, one employer but two providers and nnot enough levy available both finished on time PV2-270

	Given the employer levy account balance in collection period <Collection_Period> is <Levy Balance>
	And the following commitments exist
        | Employer   | Provider   | ULN       | priority | start date                | end date                     | agreed price |
        | employer 1 | provider a | learner a | 1        | 01/Sep/Last Academic Year | 08/Sep/Current Academic Year | 7500         |
        | employer 1 | provider b | learner b | 2        | 01/Sep/Last Academic Year | 08/Sep/Current Academic Year | 15000        |
	And the "provider a" previously submitted the following learner details
		| ULN       | Start Date                | Planned Duration | Total Training Price | Total Training Price Effective Date | Total Assessment Price | Total Assessment Price Effective Date | Actual Duration | Completion Status | Contract Type | Aim Sequence Number | Aim Reference | Framework Code | Pathway Code | Programme Type | Funding Line Type                                  | SFA Contribution Percentage |
		| learner a | 01/Sep/Last Academic Year | 12 months        | 7500                 | 01/Sep/Last Academic Year           | 0                      | 01/Sep/Last Academic Year             |                 | continuing        | Act1          | 1                   | ZPROG001      | 403            | 1            | 2              | 16-18 Apprenticeship (From May 2017) Levy Contract | 90%                         |
	And the "provider b" previously submitted the following learner details
		| ULN       | Start Date                | Planned Duration | Total Training Price | Total Training Price Effective Date | Total Assessment Price | Total Assessment Price Effective Date | Actual Duration | Completion Status | Contract Type | Aim Sequence Number | Aim Reference | Framework Code | Pathway Code | Programme Type | Funding Line Type                                  | SFA Contribution Percentage |
		| learner b | 01/Sep/Last Academic Year | 12 months        | 15000                | 01/Sep/Last Academic Year           | 0                      | 01/Sep/Last Academic Year             |                 | continuing        | Act1          | 1                   | ZPROG001      | 403            | 1            | 2              | 16-18 Apprenticeship (From May 2017) Levy Contract | 90%                         |
    And the following earnings had been generated for the learner for "provider a"
        | ULN       | Delivery Period        | On-Programme | Completion | Balancing |
        | learner a | Aug/Last Academic Year | 0            | 0          | 0         |
        | learner a | Sep/Last Academic Year | 500          | 0          | 0         |
        | learner a | Oct/Last Academic Year | 500          | 0          | 0         |
        | learner a | Nov/Last Academic Year | 500          | 0          | 0         |
        | learner a | Dec/Last Academic Year | 500          | 0          | 0         |
        | learner a | Jan/Last Academic Year | 500          | 0          | 0         |
        | learner a | Feb/Last Academic Year | 500          | 0          | 0         |
        | learner a | Mar/Last Academic Year | 500          | 0          | 0         |
        | learner a | Apr/Last Academic Year | 500          | 0          | 0         |
        | learner a | May/Last Academic Year | 500          | 0          | 0         |
        | learner a | Jun/Last Academic Year | 500          | 0          | 0         |
        | learner a | Jul/Last Academic Year | 500          | 0          | 0         |
	And the following earnings had been generated for the learner for "provider b"
		| ULN       | Delivery Period        | On-Programme | Completion | Balancing |
        | learner b | Aug/Last Academic Year | 0            | 0          | 0         |
        | learner b | Sep/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Oct/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Nov/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Dec/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Jan/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Feb/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Mar/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Apr/Last Academic Year | 1000         | 0          | 0         |
        | learner b | May/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Jun/Last Academic Year | 1000         | 0          | 0         |
        | learner b | Jul/Last Academic Year | 1000         | 0          | 0         |
    And the following "provider a" payments had been generated
        | ULN       | Collection Period      | Delivery Period        | Levy Payments | Transaction Type |
        | learner a | R02/Last Academic Year | Sep/Last Academic Year | 500           | Learning         |
        | learner a | R03/Last Academic Year | Oct/Last Academic Year | 500           | Learning         |
        | learner a | R04/Last Academic Year | Nov/Last Academic Year | 500           | Learning         |
        | learner a | R05/Last Academic Year | Dec/Last Academic Year | 500           | Learning         |
        | learner a | R06/Last Academic Year | Jan/Last Academic Year | 500           | Learning         |
        | learner a | R07/Last Academic Year | Feb/Last Academic Year | 500           | Learning         |
        | learner a | R08/Last Academic Year | Mar/Last Academic Year | 500           | Learning         |
        | learner a | R09/Last Academic Year | Apr/Last Academic Year | 500           | Learning         |
        | learner a | R10/Last Academic Year | May/Last Academic Year | 500           | Learning         |
        | learner a | R11/Last Academic Year | Jun/Last Academic Year | 500           | Learning         |
        | learner a | R12/Last Academic Year | Jul/Last Academic Year | 500           | Learning         |
	And the following "provider b" payments had been generated
        | ULN       | Collection Period      | Delivery Period        | SFA Co-Funded Payments | Employer Co-Funded Payments | Levy Payments | Transaction Type |
        | learner b | R02/Last Academic Year | Sep/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R03/Last Academic Year | Oct/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R04/Last Academic Year | Nov/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R05/Last Academic Year | Dec/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R06/Last Academic Year | Jan/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R07/Last Academic Year | Feb/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R08/Last Academic Year | Mar/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R09/Last Academic Year | Apr/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R10/Last Academic Year | May/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R11/Last Academic Year | Jun/Last Academic Year | 675                    | 75                          | 250           | Learning         |
        | learner b | R12/Last Academic Year | Jul/Last Academic Year | 675                    | 75                          | 250           | Learning         |
    But the "provider a" now changes the Learner details as follows
		| ULN       | Start Date                | Planned Duration | Total Training Price | Total Training Price Effective Date | Total Assessment Price | Total Assessment Price Effective Date | Actual Duration | Completion Status | Contract Type | Aim Sequence Number | Aim Reference | Framework Code | Pathway Code | Programme Type | Funding Line Type                                  | SFA Contribution Percentage |
		| learner a | 01/Sep/Last Academic Year | 12 months        | 7500                 | 01/Sep/Last Academic Year           | 0                      | 01/Sep/Last Academic Year             | 12 months       | completed         | Act1          | 1                   | ZPROG001      | 403            | 1            | 2              | 16-18 Apprenticeship (From May 2017) Levy Contract | 90%                         |
    And the "provider b" now changes the Learner details as follows
		| ULN       | Start Date                | Planned Duration | Total Training Price | Total Training Price Effective Date | Total Assessment Price | Total Assessment Price Effective Date | Actual Duration | Completion Status | Contract Type | Aim Sequence Number | Aim Reference | Framework Code | Pathway Code | Programme Type | Funding Line Type                                  | SFA Contribution Percentage |
		| learner b | 01/Sep/Last Academic Year | 12 months        | 15000                | 01/Sep/Last Academic Year           | 0                      | 01/Sep/Last Academic Year             | 12 months       | completed         | Act1          | 1                   | ZPROG001      | 403            | 1            | 2              | 16-18 Apprenticeship (From May 2017) Levy Contract | 90%                         |
	When the amended ILR file is re-submitted for the learners in collection period <Collection_Period> by "provider a"
	When the amended ILR file is re-submitted for the learners in collection period <Collection_Period> by "provider b"
	Then the following learner earnings should be generated for "provider a"
		| ULN       | Delivery Period           | On-Programme | Completion | Balancing |
		| learner a | Aug/Current Academic Year | 500          | 0          | 0         |
		| learner a | Sep/Current Academic Year | 0            | 1500       | 0         |
		| learner a | Oct/Current Academic Year | 0            | 0          | 0         |
		| learner a | Nov/Current Academic Year | 0            | 0          | 0         |
		| learner a | Dec/Current Academic Year | 0            | 0          | 0         |
		| learner a | Jan/Current Academic Year | 0            | 0          | 0         |
		| learner a | Feb/Current Academic Year | 0            | 0          | 0         |
		| learner a | Mar/Current Academic Year | 0            | 0          | 0         |
		| learner a | Apr/Current Academic Year | 0            | 0          | 0         |
		| learner a | May/Current Academic Year | 0            | 0          | 0         |
		| learner a | Jun/Current Academic Year | 0            | 0          | 0         |
		| learner a | Jul/Current Academic Year | 0            | 0          | 0         |
	And the following learner earnings should be generated for "provider b"
		| ULN       | Delivery Period           | On-Programme | Completion | Balancing |
		| learner b | Aug/Current Academic Year | 1000         | 0          | 0         |
		| learner b | Sep/Current Academic Year | 0            | 3000       | 0         |
		| learner b | Oct/Current Academic Year | 0            | 0          | 0         |
		| learner b | Nov/Current Academic Year | 0            | 0          | 0         |
		| learner b | Dec/Current Academic Year | 0            | 0          | 0         |
		| learner b | Jan/Current Academic Year | 0            | 0          | 0         |
		| learner b | Feb/Current Academic Year | 0            | 0          | 0         |
		| learner b | Mar/Current Academic Year | 0            | 0          | 0         |
		| learner b | Apr/Current Academic Year | 0            | 0          | 0         |
		| learner b | May/Current Academic Year | 0            | 0          | 0         |
		| learner b | Jun/Current Academic Year | 0            | 0          | 0         |
		| learner b | Jul/Current Academic Year | 0            | 0          | 0         |
    And at month end only the following payments will be calculated for "provider a"
        | ULN       | Collection Period         | Delivery Period           | On-Programme | Completion | Balancing |
        | learner a | R01/Current Academic Year | Aug/Current Academic Year | 500          | 0          | 0         |
        | learner a | R02/Current Academic Year | Sep/Current Academic Year | 0            | 1500       | 0         |
    And at month end only the following payments will be calculated for "provider b"
        | ULN       | Collection Period         | Delivery Period           | On-Programme | Completion | Balancing |
        | learner b | R01/Current Academic Year | Aug/Current Academic Year | 1000         | 0          | 0         |
        | learner b | R02/Current Academic Year | Sep/Current Academic Year | 0            | 3000       | 0         |
	And only the following "provider a" payments will be recorded
        | ULN       | Collection Period         | Delivery Period           | SFA Co-Funded Payments | Employer Co-Funded Payments | Levy Payments | Transaction Type |
        | learner a | R01/Current Academic Year | Aug/Current Academic Year | 0                      | 0                           | 500           | Learning         |
        | learner a | R02/Current Academic Year | Sep/Current Academic Year | 450                    | 50                          | 1000          | Completion       |
	And only the following "provider b" payments will be recorded
        | ULN       | Collection Period         | Delivery Period           | SFA Co-Funded Payments | Employer Co-Funded Payments | Levy Payments | Transaction Type |
        | learner b | R01/Current Academic Year | Aug/Current Academic Year | 450                    | 50                          | 500           | Learning         |
        | learner b | R02/Current Academic Year | Sep/Current Academic Year | 2700                   | 300                         | 0             | Completion       |
	And only the following "provider a" payments will be generated
        | ULN       | Collection Period         | Delivery Period           | SFA Co-Funded Payments | Employer Co-Funded Payments | Levy Payments | Transaction Type |
        | learner a | R01/Current Academic Year | Aug/Current Academic Year | 0                      | 0                           | 500           | Learning         |
        | learner a | R02/Current Academic Year | Sep/Current Academic Year | 450                    | 50                          | 1000          | Completion       |
	And only the following "provider b" payments will be generated
        | ULN       | Collection Period         | Delivery Period           | SFA Co-Funded Payments | Employer Co-Funded Payments | Levy Payments | Transaction Type |
        | learner b | R01/Current Academic Year | Aug/Current Academic Year | 450                    | 50                          | 500           | Learning         |
        | learner b | R02/Current Academic Year | Sep/Current Academic Year | 2700                   | 300                         | 0             | Completion       |
Examples: 
        | Collection_Period         | Levy Balance |
        | R01/Current Academic Year | 1000         |
        | R02/Current Academic Year | 1000         |
        | R03/Current Academic Year | 0            |