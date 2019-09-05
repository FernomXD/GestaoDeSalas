# API - Gestao de salas
 
 <h2>Funcionário</h2>
 Funcionários são utilizados para inserir um novo registro de sala ou para agendar o uso de uma sala.
 </br>
 
| Nome da variável | Tipo da variável | Descrição                    |
|------------------|------------------|------------------------------|
| Nome             | string           | Nome do Funcionário          |
| Usuario          | string           | Usuário de acesso para a API |
| Senha            | string           | Senha de acesso para a API   |
 
 
 <h4>Novo funcionário</h4>
 
| POST | SeuDominio.com.br/api/Funcionarios |
|------|------------------------------------|
 


| Nome da variável | Tipo da variável | Descrição                    | Obrigatório |
|------------------|------------------|------------------------------|-------------|
| Nome             | string           | Nome do Funcionário          | Sim         |
| Usuario          | string           | Usuário de acesso para a API | Sim         |
| Senha            | string           | Senha de acesso para a API   | Sim         |
 
 ![image](https://user-images.githubusercontent.com/37151034/64082011-23171780-ccdf-11e9-85c7-4c66f625eb68.png)
 
 <h4>Listar funcionários</h4>
 
 
| GET | SeuDominio.com.br/api/Funcionarios |
|------|-----------------------------------|
 

![image](https://user-images.githubusercontent.com/37151034/64082056-8b65f900-ccdf-11e9-82bc-4c1530c3dcb6.png)
 
 
<h1>Autenticação</h1>

| POST | SeuDominio.com.br/NewToken |
|------|----------------------------|


| Nome da variável | Tipo da variável | Descrição                    | Obrigatório |
|------------------|------------------|------------------------------|-------------|
| UserName         | string           | Usuário                      | Sim         |
| Password         | string           | Senha                        | Sim         |
| grant_type       | string           | inserir password nesse campo | Sim         |


![image](https://user-images.githubusercontent.com/37151034/64081766-c23a1000-ccdb-11e9-9c32-c4c23d6ce2f2.png)


Uma vez autenticado na plataforma, basta utilizar esse token para acessar a plataforma.



<h1>Criando uma nova sala</h1>

Para inserir uma sala basta informar no Headers a key Authorization com os valores recebidos na autenticação e no body inserir o nome da sala  e descrição da sala


<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64351402-9f0bab00-cfd0-11e9-8322-8452cbbbf15c.png)

<h3>Informações da sala</h3>

| Nome da variável | Tipo da variável | Descrição                    | Obrigatório |
|------------------|------------------|------------------------------|-------------|
| NomeSala         | string           | Nome da sala no sistema      | Sim         |
| DescricaoSala    | string           | Descrição da sala            | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64351662-18a39900-cfd1-11e9-9df4-b9b7a3b45b25.png)
