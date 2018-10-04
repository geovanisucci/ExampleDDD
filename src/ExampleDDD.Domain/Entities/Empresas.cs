namespace ExampleDDD.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Empresas
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string RazaoSocial { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; }

        public int? IdTipoLogradouro { get; set; }

        [StringLength(100)]
        public string Logradouro { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        [StringLength(100)]
        public string Complemento { get; set; }

        [StringLength(100)]
        public string Bairro { get; set; }

        [StringLength(9)]
        public string Cep { get; set; }

        public int IdEstado { get; set; }

        public int IdMunicipio { get; set; }

        public int IdPais { get; set; }

        [StringLength(1)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(18)]
        public string CnpjCpf { get; set; }

        public bool? Ativo { get; set; }

        public virtual Estados Estados { get; set; }

        public virtual Municipios Municipios { get; set; }

        public virtual Paises Paises { get; set; }

        public virtual TipoLogradouros TipoLogradouros { get; set; }
    }
}
