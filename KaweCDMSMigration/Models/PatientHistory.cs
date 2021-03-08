using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaweCDMSMigration.Models
{
    public class PatientHistory
    {
        public int ID { get; set; }
        public int Ptn_pk { get; set; }
        public int Visit_Pk { get; set; }
        public int LocationId { get; set; }
	    public int UserId { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public bool EPMotherAlive { get; set; }
        public string EPMothersName { get; set; }
	    public int EPMothersAge { get; set; }
        public string EPMothersOccupation { get; set; }
	    public int EPMothersMaritalStatus { get; set; }
        public int EPMothersEucation { get; set; }
        public bool EPFatherAlive { get; set; }
        public string EPFathersName { get; set; }
	    public int EPFathersAge { get; set; }
        public string EPFathersOccupation { get; set; }
	    public int EPFathersEducation { get; set; }
        public bool EPHistoryConvulsion { get; set; }
        public string EPHistoryRetardation { get; set; }
	    public int EPPxBirthOrder { get; set; }
        public int EPMothersAgePxBirth { get; set; }
        public bool EPMotherSickDuringPregnancy { get; set; }
        public string EPDescribeSicknessDuringPregnancy { get; set; }
        public int EPDurationPregnancy { get; set; }
        public int EPMultipleBirth { get; set; }
        public int EPPlaceOfDelivery { get; set; }
        public int EPModeOfDelivery { get; set; }
        public int EPDurationOfDelivery { get; set; }
        public int EPSizeOfBaby { get; set; }
        public int EPWhatAge1stSeizure { get; set; }
        public string EPFullSeizureDescription { get; set; }
	    public bool EPUnconsiousness { get; set; }
	    public bool EPCloudingConsiousness { get; set; }
	    public bool EPStiffness { get; set; }
        public int EPJerking { get; set; }
        public bool EPJerkingSmallMovements { get; set; }
        public bool EPNoMovementSloppyness { get; set; }
        public bool EPMainlyStrangeBehavior { get; set; }
        public bool EPDroolingSaliva { get; set; }
        public bool EPBittingTongue { get; set; }
        public bool EPIncontinenceStoolUrine { get; set; }
        public bool EPDoesPxKnowSeizureComing { get; set; }
        public string EPHowPxKnowsSeizureComing { get; set; }
        public bool EPAlwaysFeverWithSeizure { get; set; }
        public int EPSeizureSameAsFirstAttack { get; set; }
        public System.DateTime EPWhenLastSeizure { get; set; }
        public System.DateTime EPWhenLastSeizureBeforeLast { get; set; }
        public bool EPSeizureConsecutiveDays { get; set; }
        public bool EPSeizuresRelatedNaturalEvents { get; set; }
        public int EPWhenSeizuresOccurMostly { get; set; }
        public int EPSmileMilestone { get; set; }
        public int  EPCrawlMilestone { get; set; }
        public int EPSitMilestone { get; set; }
        public int EPStandMilestone { get; set; }
        public int EPWalkMilestone { get; set; }
        public int EPTalkMilestone { get; set; }
        public int EPFeedMilestone { get; set; }
        public int EPToiletTrainedMilestone { get; set; }
        public bool EPWeaknessLimbs { get; set; }
        public bool EPStiffnessLimbs { get; set; }
        public bool EPDoesPxSeeWell { get; set; }
        public bool EPDoesPxHearWell { get; set; }
        public bool EPDoesPxTalkWell { get; set; }
        public int EPPxMentalBehavior { get; set; }
        public int EPMentalRetardation { get; set; }
        public int EPImmunizationStatusChild { get; set; }
        public int EPDailyPxActivities { get; set; }
        public int EPReasonNoSchooling { get; set; }
        public int EPPxDailyActivitiesNotSchool { get; set; }
        public bool EPPxTraining { get; set; }
        public bool EPPxpaidforWork { get; set; }
        public int EPPxAdultFemalwithKids { get; set; }
        public bool EPPxCouncelledContraceptives { get; set; }
        public string EPHAdmissionReason { get; set; }
        public int intEPIWhatAgeFirstSeizureMonths { get; set; }
        public string EPISeizureDiagnosisMore { get; set; }

    }
}