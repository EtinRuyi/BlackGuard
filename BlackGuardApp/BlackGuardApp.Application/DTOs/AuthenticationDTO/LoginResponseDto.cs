﻿namespace BlackGuardApp.Application.DTOs.AuthenticationDTO
{
    public class LoginResponseDto
    {
        public string JWToken { get; set; }
        public bool IsPasswordSet { get; set; }
    }
}
