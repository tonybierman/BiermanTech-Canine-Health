using System.ComponentModel.DataAnnotations;

namespace BiermanTech.CanineHealth
{
    /// <summary>
    /// Defines canine development stages from puppy to adult, based on veterinary and ethological guidelines.
    /// </summary>
    public enum DevelopmentStageEnum
    {
        /// <summary>
        /// No specific development stage assigned (invalid for evaluation).
        /// </summary>
        [Display(Name = "None", Description = "No specific development stage assigned (invalid for evaluation).")]
        None = 0,

        /// <summary>
        /// Neonatal stage (0-2 weeks), characterized by dependency on the mother, limited sensory abilities, and basic reflexes like suckling.
        /// </summary>
        [Display(Name = "Neonatal", Description = "Neonatal stage (0-2 weeks), characterized by dependency on the mother, limited sensory abilities, and basic reflexes like suckling.")]
        Neonatal = 1,

        /// <summary>
        /// Transitional stage (2-4 weeks), marked by opening of eyes and ears, initial mobility, and early social interactions.
        /// </summary>
        [Display(Name = "Transitional", Description = "Transitional stage (2-4 weeks), marked by opening of eyes and ears, initial mobility, and early social interactions.")]
        Transitional = 2,

        /// <summary>
        /// Socialization stage (4-12 weeks), critical for social and environmental learning, with rapid physical growth and play behavior.
        /// </summary>
        [Display(Name = "Socialization", Description = "Socialization stage (4-12 weeks), critical for social and environmental learning, with rapid physical growth and play behavior.")]
        Socialization = 3,

        /// <summary>
        /// Juvenile stage (3-6 months), involving continued growth, teething, and increased independence, with training becoming important.
        /// </summary>
        [Display(Name = "Juvenile", Description = "Juvenile stage (3-6 months), involving continued growth, teething, and increased independence, with training becoming important.")]
        Juvenile = 4,

        /// <summary>
        /// Adolescent stage (6-18 months), characterized by sexual maturity, high energy, and behavioral testing, requiring consistent training.
        /// </summary>
        [Display(Name = "Adolescent", Description = "Adolescent stage (6-18 months), characterized by sexual maturity, high energy, and behavioral testing, requiring consistent training.")]
        Adolescent = 5,

        /// <summary>
        /// Adult stage (18 months and older), marked by physical and behavioral maturity, with stable temperament and full development.
        /// </summary>
        [Display(Name = "Adult", Description = "Adult stage (18 months and older), marked by physical and behavioral maturity, with stable temperament and full development.")]
        Adult = 6
    }
}