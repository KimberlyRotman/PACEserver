using Models.Enums;

namespace Models.Abstractions;

internal interface ITarefa
    : Ids
{
    public Guid Id { get; set; }
    string Titulo { get; set; }
    string Descricao { get; set; }
    int maximoIntegrantes { get; set; }
    TipoTarefa Tipo { get; set; }
    bool Apresentacao { get; set; }

    DateTime? DataApresentacao { get; set; }
    DateTime DataEntrega { get; set; }
    DateTime DataCriacao { get; set; }

    IPlataforma Plataforma { get; set; }
    IEquipe Equipe { get; set; }
    IMateria Materia { get; set; }

}
