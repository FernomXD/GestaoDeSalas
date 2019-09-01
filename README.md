# API - Gestao de salas
 
 <h2>Funcionário</h2>
 Funcionários são utilizados para inserir um novo registro de sala ou para agendar o uso de uma sala.
 
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

![image](https://user-images.githubusercontent.com/37151034/64081766-c23a1000-ccdb-11e9-9c32-c4c23d6ce2f2.png)
