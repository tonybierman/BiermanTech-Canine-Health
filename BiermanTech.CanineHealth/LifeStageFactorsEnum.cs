using System.ComponentModel.DataAnnotations;

namespace BiermanTech.CanineHealth
{
    /// <summary>
    /// Defines the life stages and conditions of a dog that affect its Maintenance Energy Requirement (MER) factors.
    /// </summary>
    public enum LifeStageFactorsEnum
    {
        /// <summary>
        /// No specific life stage or condition (invalid for MER calculation).
        /// </summary>
        [Display(Name = "None", Description = "No specific life stage or condition assigned (invalid for Maintenance Energy Requirement calculation).")]
        None = 0,

        /// <summary>
        /// Neutered adult dog.
        /// </summary>
        [Display(Name = "Neutered Adult", Description = "Neutered adult dog, typically requiring lower energy intake due to reduced metabolic rate post-neutering.")]
        NeuteredAdult = 1,

        /// <summary>
        /// Intact (non-neutered) adult dog.
        /// </summary>
        [Display(Name = "Intact Adult", Description = "Intact adult dog, with higher energy needs compared to neutered dogs due to active reproductive hormones.")]
        IntactAdult = 2,

        /// <summary>
        /// Inactive or obesity-prone dog.
        /// </summary>
        [Display(Name = "Inactive/Obese Prone", Description = "Inactive or obesity-prone dog, requiring reduced energy intake to prevent weight gain due to low activity or metabolic predisposition.")]
        InactiveObeseProne = 3,

        /// <summary>
        /// Dog on a weight loss plan.
        /// </summary>
        [Display(Name = "Weight Loss", Description = "Dog on a weight loss plan, requiring carefully controlled energy intake to achieve healthy weight reduction.")]
        WeightLoss = 4,

        /// <summary>
        /// Dog requiring weight gain.
        /// </summary>
        [Display(Name = "Weight Gain", Description = "Dog requiring weight gain, needing increased energy intake to support healthy weight restoration, often due to undernourishment or recovery.")]
        WeightGain = 5,

        /// <summary>
        /// Active working dog with high energy needs.
        /// </summary>
        [Display(Name = "Active Working Dog", Description = "Active working dog, such as those in agility, herding, or service roles, requiring significantly higher energy intake to support intense physical demands.")]
        ActiveWorkingDog = 6,

        /// <summary>
        /// Puppy aged 0 to 4 months.
        /// </summary>
        [Display(Name = "Puppy (0-4 Months)", Description = "Puppy aged 0 to 4 months, with high energy needs to support rapid growth, development, and immune system maturation.")]
        Puppy0To4Months = 7,

        /// <summary>
        /// Puppy aged 4 months to adulthood.
        /// </summary>
        [Display(Name = "Puppy (4 Months to Adult)", Description = "Puppy aged 4 months to adulthood, requiring elevated energy intake for continued growth and increasing activity levels, though less than younger puppies.")]
        Puppy4MonthsToAdult = 8,

        /// <summary>
        /// Pregnant (gestating) dog.
        /// </summary>
        [Display(Name = "Gestation", Description = "Pregnant (gestating) dog, with increased energy requirements to support fetal development, particularly in the later stages of pregnancy.")]
        Gestation = 9,

        /// <summary>
        /// Lactating (nursing) dog.
        /// </summary>
        [Display(Name = "Lactation", Description = "Lactating (nursing) dog, requiring significantly higher energy intake to support milk production and the nutritional demands of nursing puppies.")]
        Lactation = 10
    }
}