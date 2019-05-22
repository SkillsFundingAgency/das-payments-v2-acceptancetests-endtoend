﻿
Feature: Data Lock - DLOCK12 - when the employer pauses payments for a learner on a commitment PV2-713
		As a Provider,
		I want to be notified with a DLOCK12 when the Employer pauses a learner's payment
		So that I can take the correct action for that learner

Scenario: DLOCK12 - when the employer pauses payments for a learner on a commitment - PV2-713
	Given the employer levy account balance in collection period R12/Current Academic Year is 10000
	And the following apprenticeships exist
		| Identifier       | framework code | programme type | pathway code | agreed price | start date                   | end date                  | status |
		| Apprenticeship a | 593            | 20             | 1            | 10000        | 01/May/Current Academic Year | 01/May/Next Academic Year | active |
	And the apprenticeships status changes as follows
		| Collection Period         | status |Identifier       |
		| R12/Current Academic Year | paused |Apprenticeship a |
	And the provider is providing training for the following learners
		| Start Date                   | Planned Duration | Total Training Price | Total Training Price Effective Date | Total Assessment Price | Total Assessment Price Effective Date | Actual Duration | Completion Status | Contract Type | Aim Sequence Number | Aim Reference | Framework Code | Pathway Code | Programme Type | Funding Line Type                                | SFA Contribution Percentage |
		| 01/May/Current Academic Year | 12 months        | 10000                | 01/May/Current Academic Year        |                        |                                       |                 | continuing        | Act1          | 1                   | ZPROG001      | 593            | 1            | 20             | 19+ Apprenticeship (From May 2017) Levy Contract | 90%                         |
    And price details as follows
		| Price Episode Id  | Total Training Price | Total Training Price Effective Date | Contract Type  | SFA Contribution Percentage |
		| pe-1              | 10000                | 01/May/Current Academic Year        | Act1           | 90%                         |
	When the ILR file is submitted for the learners for collection period R12/Current Academic Year
	Then the following learner earnings should be generated
		| Delivery Period           | On-Programme | Completion | Balancing |
		| Aug/Current Academic Year | 0            | 0          | 0         |
		| Sep/Current Academic Year | 0            | 0          | 0         |
		| Oct/Current Academic Year | 0            | 0          | 0         |
		| Nov/Current Academic Year | 0            | 0          | 0         |
		| Dec/Current Academic Year | 0            | 0          | 0         |
		| Jan/Current Academic Year | 0            | 0          | 0         |
		| Feb/Current Academic Year | 0            | 0          | 0         |
		| Mar/Current Academic Year | 0            | 0          | 0         |
		| Apr/Current Academic Year | 0            | 0          | 0         |
		| May/Current Academic Year | 666.66667    | 0          | 0         |
		| Jun/Current Academic Year | 666.66667    | 0          | 0         |
		| Jul/Current Academic Year | 666.66667    | 0          | 0         |
    And the following data lock failures were generated
        | Apprenticeship   | Delivery Period           | Framework Code | Programme Type | Pathway Code | Transaction Type | Error Code | Price Episode Identifier |
        | Apprenticeship a | May/Current Academic Year | 593            | 20             | 1            | Learning         | DLOCK_12   | pe-1                     |
        | Apprenticeship a | Jun/Current Academic Year | 593            | 20             | 1            | Learning         | DLOCK_12   | pe-1                     |
        | Apprenticeship a | Jul/Current Academic Year | 593            | 20             | 1            | Learning         | DLOCK_12   | pe-1                     |
	And Month end is triggered
	And no provider payments will be generated
	And no provider payments will be recorded




#Scenario: DLOCK12 - When the Employer pauses payments for a learner on a Commitment then datalock DLOCK_12 will be produced
#
#    Given the following commitments exist:
#        | commitment Id | version Id | Provider   | ULN       | framework code | programme type | pathway code | agreed price | start date | end date   | status  | effective from | effective to   |
#        | 73            | 73-125     | Provider a | learner a | 450            | 2              | 1            | 10000        | 01/05/2018 | 01/05/2019 | active  | 01/05/2018     | 30/06/2018     |
#		| 73            | 73-125     | Provider a | learner a | 450            | 2              | 1            | 10000        | 01/05/2018 | 01/05/2019 | paused  | 01/07/2018     | 			    |
#        
#    When an ILR file is submitted with the following data:  
#        | Provider   | ULN       | framework code | programme type | pathway code | start date | planned end date | completion status | Total training price | Total training price effective date |
#        | Provider a | learner a | 450            | 2              | 1            | 01/05/2018 | 08/05/2019       | active    	      | 10000                | 01/05/2018                          |
#  
#
#    Then the following data lock event is returned:
#	
#        | Price Episode identifier  | Apprenticeship Id | ULN       | ILR Start Date | ILR Training Price | 
#        | 2-450-1-01/05/2018        | 73                | learner a | 01/05/2018     | 10000              |
#    
#	And the data lock event has the following errors:    
#        | Price Episode identifier  | Error code | Error Description	   								 |
#        | 2-450-1-01/05/2018        | DLOCK_12   | The Employer has paused payments for this apprentice  |
#    
#	And the data lock event has the following periods    
#        | Price Episode identifier | Period   | Payable Flag | Transaction Type |
#        | 2-450-1-01/05/2018       | 1718-R10 | true         | Learning         |
#        | 2-450-1-01/05/2018       | 1718-R11 | true         | Learning         |
#		| 2-450-1-01/05/2018       | 1718-R12 | false        | Learning         |
#    
#	And the data lock event used the following commitments 
#	
#        | Price Episode identifier | Apprentice Version | Start Date | framework code | programme type | pathway code | status  | Negotiated Price | Effective Date |
#        | 2-450-1-01/05/2018       | 73-125             | 01/05/2018 | 450            | 2              | 1            | paused  | 10000            | 01/07/2018     |

