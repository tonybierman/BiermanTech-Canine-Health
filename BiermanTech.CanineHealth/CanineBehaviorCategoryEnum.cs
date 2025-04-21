using System.ComponentModel.DataAnnotations;

namespace BiermanTech.CanineHealth
{
    /// <summary>
    /// Defines categories of canine behavior based on evolutionary and cognitive aspects, as described in Miklósi's Dog Behavior.
    /// </summary>
    public enum CanineBehaviorCategoryEnum
    {
        /// <summary>
        /// No specific behavior category assigned (invalid for evaluation).
        /// </summary>
        [Display(Name = "None", Description = "No specific behavior category assigned (invalid for evaluation).")]
        None = 0,

        /// <summary>
        /// Social behaviors involving interactions with other dogs or humans, such as bonding, submission, or dominance.
        /// </summary>
        [Display(Name = "Social", Description = "Social behaviors involving interactions with other dogs or humans, such as bonding, submission, or dominance.")]
        Social = 1,

        /// <summary>
        /// Communicative behaviors, including vocalizations (barking, howling) and body language (tail wagging, ear positioning).
        /// </summary>
        [Display(Name = "Communicative", Description = "Communicative behaviors, including vocalizations (barking, howling) and body language (tail wagging, ear positioning).")]
        Communicative = 2,

        /// <summary>
        /// Instinctive behaviors driven by survival instincts, such as hunting, guarding, or digging.
        /// </summary>
        [Display(Name = "Instinctive", Description = "Instinctive behaviors driven by survival instincts, such as hunting, guarding, or digging.")]
        Instinctive = 3,

        /// <summary>
        /// Emotional behaviors reflecting internal states, such as fear, anxiety, or excitement.
        /// </summary>
        [Display(Name = "Emotional", Description = "Emotional behaviors reflecting internal states, such as fear, anxiety, or excitement.")]
        Emotional = 4,

        /// <summary>
        /// Learned behaviors shaped by training or environmental conditioning, such as obedience or problem behaviors.
        /// </summary>
        [Display(Name = "Learned", Description = "Learned behaviors shaped by training or environmental conditioning, such as obedience or problem behaviors.")]
        Learned = 5,

        /// <summary>
        /// Exploratory behaviors driven by curiosity, such as sniffing or investigating new environments.
        /// </summary>
        [Display(Name = "Exploratory", Description = "Exploratory behaviors driven by curiosity, such as sniffing or investigating new environments.")]
        Exploratory = 6,

        /// <summary>
        /// Reproductive behaviors related to mating or parental care, such as courtship or nurturing puppies.
        /// </summary>
        [Display(Name = "Reproductive", Description = "Reproductive behaviors related to mating or parental care, such as courtship or nurturing puppies.")]
        Reproductive = 7
    }
}