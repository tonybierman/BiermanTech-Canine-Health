namespace BiermanTech.CanineHealth
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Defines the body condition scores (BCS) for assessing a dog's weight and health status.
    /// Based on the 9-point scale used in veterinary practice.
    /// </summary>
    public enum BodyConditionScoreEnum
    {
        /// <summary>
        /// No specific body condition (invalid for BCS assessment).
        /// </summary>
        [Display(Name = "None", Description = "No specific body condition assigned (invalid for evaluation).")]
        None = 0,

        /// <summary>
        /// Emaciated: Severe muscle loss, no palpable fat, bones highly visible.
        /// </summary>
        [Display(Name = "Emaciated", Description = "Emaciated condition with severe muscle loss, no palpable fat, and highly visible ribs, spine, and pelvic bones, indicating extreme undernourishment.")]
        Emaciated = 1,

        /// <summary>
        /// Very Thin: Some muscle loss, minimal fat, ribs and spine easily visible.
        /// </summary>
        [Display(Name = "Very Thin", Description = "Very thin condition with some muscle loss, minimal fat cover, and easily visible ribs and spine, suggesting significant underweight status.")]
        VeryThin = 2,

        /// <summary>
        /// Thin: Ribs visible, slight fat cover, obvious waist and abdominal tuck.
        /// </summary>
        [Display(Name = "Thin", Description = "Thin condition with visible ribs, slight fat cover, and a pronounced waist and abdominal tuck, indicating a lean but healthy frame.")]
        Thin = 3,

        /// <summary>
        /// Underweight: Ribs easily palpable, minimal fat, prominent waist and tuck.
        /// </summary>
        [Display(Name = "Underweight", Description = "Underweight condition with easily palpable ribs, minimal fat, and a prominent waist and abdominal tuck, slightly below optimal weight.")]
        Underweight = 4,

        /// <summary>
        /// Ideal: Ribs palpable with slight fat cover, well-defined waist and tuck.
        /// </summary>
        [Display(Name = "Ideal", Description = "Ideal condition with ribs palpable under a slight fat cover, a well-defined waist, and clear abdominal tuck, reflecting optimal health and weight.")]
        Ideal = 5,

        /// <summary>
        /// Overweight: Ribs palpable with difficulty, noticeable fat, reduced waist.
        /// </summary>
        [Display(Name = "Overweight", Description = "Overweight condition with ribs palpable only with difficulty, noticeable fat deposits, and a reduced waistline, indicating excess weight.")]
        Overweight = 6,

        /// <summary>
        /// Heavy: Ribs difficult to palpate, thick fat cover, minimal waist.
        /// </summary>
        [Display(Name = "Heavy", Description = "Heavy condition with ribs difficult to palpate under thick fat cover, minimal waist, and reduced abdominal tuck, suggesting significant excess weight.")]
        Heavy = 7,

        /// <summary>
        /// Obese: Ribs not palpable, heavy fat deposits, no waist or tuck.
        /// </summary>
        [Display(Name = "Obese", Description = "Obese condition with ribs not palpable, heavy fat deposits, no discernible waist or abdominal tuck, posing health risks.")]
        Obese = 8,

        /// <summary>
        /// Severely Obese: Extreme fat deposits, significant health risks.
        /// </summary>
        [Display(Name = "Severely Obese", Description = "Severely obese condition with extreme fat deposits, no palpable ribs or waist, and significant health risks due to excessive weight.")]
        SeverelyObese = 9
    }
}