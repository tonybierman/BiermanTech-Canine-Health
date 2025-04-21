using System.ComponentModel.DataAnnotations;

namespace BiermanTech.CanineHealth
{
    /// <summary>
    /// Defines levels of canine appetite based on observable feeding behavior, aligned with veterinary health evaluation guidelines.
    /// </summary>
    public enum AppetiteLevelEnum
    {
        /// <summary>
        /// No specific appetite level assigned (invalid for evaluation).
        /// </summary>
        [Display(Name = "None", Description = "No specific appetite level assigned (invalid for evaluation).")]
        None = 0,

        /// <summary>
        /// No interest in food, refusing to eat, often indicating health issues or stress.
        /// </summary>
        [Display(Name = "Absent", Description = "No interest in food, refusing to eat, often indicating health issues or stress.")]
        Absent = 1,

        /// <summary>
        /// Reduced interest in food, eating less than usual, possibly due to mild illness, stress, or pickiness.
        /// </summary>
        [Display(Name = "Low", Description = "Reduced interest in food, eating less than usual, possibly due to mild illness, stress, or pickiness.")]
        Low = 2,

        /// <summary>
        /// Normal appetite, eating typical amounts with enthusiasm, indicating good health and well-being.
        /// </summary>
        [Display(Name = "Normal", Description = "Normal appetite, eating typical amounts with enthusiasm, indicating good health and well-being.")]
        Normal = 3,

        /// <summary>
        /// Increased appetite, eating more than usual or showing heightened food-seeking behavior, possibly due to activity, growth, or mild hunger.
        /// </summary>
        [Display(Name = "High", Description = "Increased appetite, eating more than usual or showing heightened food-seeking behavior, possibly due to activity, growth, or mild hunger.")]
        High = 4,

        /// <summary>
        /// Excessive appetite, voracious eating or constant food-seeking, potentially indicating medical conditions or behavioral issues.
        /// </summary>
        [Display(Name = "Excessive", Description = "Excessive appetite, voracious eating or constant food-seeking, potentially indicating medical conditions or behavioral issues.")]
        Excessive = 5
    }
}