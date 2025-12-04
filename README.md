
# Pece.Server

Esse projeto se tarta de uma Web-API para a solução PACE.Cliente disponível em:

https://github.com/KimberlyRotman/PACE.client





## Arquitetura

- .NET 9 / ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger
- Swashbuckle
- Git/Github


## Instalação

Tenha instalado 

Em uma pasta abra o terminal para clonar o projeto
Instale o projeto Pace.server com npm

```bash
git clone https://github.com/KimberlyRotman/PACEserver
cd ./PACEserver/
dotnet restore
dotnet ef database update
dotnet run .\PACEserver.http
```
    
## Endpoints

### Alunos Controller

| Método | Rota                     | Ação                                                                  |
| ------ | ------------------------ | --------------------------------------------------------------------- |
| GET    | `/Aluno`                 | Lista todos os alunos                                                 |
| GET    | `/Aluno/{id}`            | Busca aluno por **Guid**                                              |
| GET    | `/Aluno/codigo/{codigo}` | Busca aluno por **Código int**                                        |
| GET    | `/Aluno/{id}/materias`   | Lista as matérias vinculadas ao aluno                                 |
| GET    | `/Aluno/{id}/tarefas`    | Retorna todas as tarefas das matérias em que o aluno está matriculado |
| POST   | `/Aluno/cadastro`        | Cadastra novo aluno e gera código automático                          |
| POST   | `/Aluno/login`           | Login do aluno (valida senha)                                         |
| POST   | `/Aluno/matricular`      | Matricula um aluno em uma matéria e cria relação com tarefas          |
| PUT    | `/Aluno`                 | Atualiza um aluno existente                                           |
| DELETE | `/Aluno/{id}`            | Remove um aluno                                                       |


### Materia Controller

| Método | Rota                    | Ação                                 |
| ------ | ----------------------- | ------------------------------------ |
| GET    | `/Materia`              | Lista todas as matérias              |
| GET    | `/Materia/{id}`         | Retorna uma matéria por **Guid**     |
| GET    | `/Materia/{id}/tarefas` | Lista tarefas vinculadas à matéria   |
| GET    | `/Materia/{id}/alunos`  | Lista alunos matriculados na matéria |
| POST   | `/Materia`              | Cria uma nova matéria                |
| PUT    | `/Materia`              | Atualiza uma matéria                 |
| DELETE | `/Materia/{id}`         | Deleta uma matéria                   |
| DELETE | `/Materia`              | Deleta **todas** as matérias         |


## Plataforma Controller

| Método | Rota              | Ação                                   |
| ------ | ----------------- | -------------------------------------- |
| GET    | `/api/plataforma` | Lista todas as plataformas cadastradas |


## TarefaAlunoController

| Método | Rota                      | Ação                                      |
| ------ | ------------------------- | ----------------------------------------- |
| GET    | `/tarefasAluno/{alunoId}` | Retorna tarefas vinculadas a um aluno     |
| PUT    | `/tarefasAluno/status`    | Atualiza status/kanbam da tarefa do aluno |


## TarefaController

| Método | Rota               | Ação                                         |
| ------ | ------------------ | -------------------------------------------- |
| GET    | `/Tarefa`          | Lista todas as tarefas                       |
| GET    | `/Tarefa/{id}`     | Busca tarefa por **Guid**                    |
| GET    | `/Tarefa/{codigo}` | Busca tarefa por **Código int**              |
| POST   | `/Tarefa`          | Cria tarefa com código sequencial automático |
| PUT    | `/Tarefa`          | Atualiza tarefa existente                    |
| DELETE | `/Tarefa/{id}`     | Deleta tarefa                                |
