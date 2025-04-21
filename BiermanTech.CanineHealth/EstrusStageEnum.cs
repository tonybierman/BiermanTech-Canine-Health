namespace BiermanTech.CanineHealth
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the stages of a dog's estrus cycle.
    /// </summary>
    public enum EstrusStageEnum
    {
        /// <summary>
        /// No specific estrus stage (invalid for estrus-related calculations).
        /// </summary>
        [Display(Name = "None", Description = "No specific estrus stage assigned (invalid for evaluation).")]
        None = 0,

        /// <summary>
        /// Proestrus stage, characterized by the beginning of heat with vaginal bleeding and swelling.
        /// </summary>
        [Display(Name = "Proestrus", Description = "Proestrus stage (typically 7-10 days), marked by vaginal bleeding, vulvar swelling, and attraction of males, but the female is not yet receptive to mating.")]
        Proestrus = 1,

        /// <summary>
        /// Estrus stage, the fertile period when the female is receptive to mating.
        /// </summary>
        [Display(Name = "Estrus", Description = "Estrus stage (typically 5-10 days), the fertile period when the female is receptive to mating, with ovulation occurring and minimal bleeding.")]
        Estrus = 2,

        /// <summary>
        /// Diestrus stage, post-ovulation period where the body prepares for pregnancy or returns to normal.
        /// </summary>
        [Display(Name = "Diestrus", Description = "Diestrus stage (typically 60-90 days), post-ovulation period where the body supports potential pregnancy or returns to a non-reproductive state if not pregnant.")]
        Diestrus = 3,

        /// <summary>
        /// Anestrus stage, the resting phase with no reproductive activity.
        /// </summary>
        [Display(Name = "Anestrus", Description = "Anestrus stage (typically 4-5 months), the resting phase with no reproductive activity, characterized by hormonal and physical inactivity in the reproductive system.")]
        Anestrus = 4
    }
}