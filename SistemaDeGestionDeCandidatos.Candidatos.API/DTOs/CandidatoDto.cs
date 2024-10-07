﻿using System.ComponentModel.DataAnnotations;

namespace SistemaDeGestionDeCandidatos.Candidatos.API.DTOs
{
    public class CandidatoDto
    {
        public int IdCandidate { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? ModifyDate { get; set; }
    }
}
