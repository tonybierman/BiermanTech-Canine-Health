using System.ComponentModel.DataAnnotations;

namespace BiermanTech.CanineHealth
{
    /// <summary>
    /// Defines levels of canine coat condition based on observable characteristics, aligned with veterinary health evaluation guidelines.
    /// </summary>
    public enum CoatConditionEnum
    {
        /// <summary>
        /// No specific coat condition assigned (invalid for evaluation).
        /// </summary>
        [Display(Name = "None", Description = "No specific coat condition assigned (invalid for evaluation).")]
        None = 0,

        /// <summary>
        /// Poor coat condition, characterized by dullness, excessive shedding, bald patches, or skin issues, often indicating health or nutritional deficiencies.
        /// </summary>
        [Display(Name = "Poor", Description = "Poor coat condition, characterized by dullness, excessive shedding, bald patches, or skin issues, often indicating health or nutritional deficiencies.")]
        Poor = 1,

        /// <summary>
        /// Fair coat condition, with some dullness, minor flaking, or uneven texture, suggesting suboptimal health or grooming needs.
        /// </summary>
        [Display(Name = "Fair", Description = "Fair coat condition, with some dullness, minor flaking, or uneven texture, suggesting suboptimal health or grooming needs.")]
        Fair = 2,

        /// <summary>
        /// Good coat condition, with a smooth, shiny coat and minimal shedding, indicating adequate health and grooming.
        /// </summary>
        [Display(Name = "Good", Description = "Good coat condition, with a smooth, shiny coat and minimal shedding, indicating adequate health and grooming.")]
        Good = 3,

        /// <summary>
        /// Very good coat condition, with a lustrous, well-maintained coat and no skin issues, reflecting optimal health and care.
        /// </summary>
        [Display(Name = "Very Good", Description = "Very good coat condition, with a lustrous, well-maintained coat and no skin issues, reflecting optimal health and care.")]
        VeryGood = 4,

        /// <summary>
        /// Excellent coat condition, with a vibrant, glossy coat, perfect texture, and no flaws, indicative of exceptional health and grooming.
        /// </summary>
        [Display(Name = "Excellent", Description = "Excellent coat condition, with a vibrant, glossy coat, perfect texture, and no flaws, indicative of exceptional health and grooming.")]
        Excellent = 5
    }
}