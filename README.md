# API - Gestao de salas
 
 <h2>Funcionário</h2>
 Funcionários são utilizados para inserir um novo registro de sala ou para agendar o uso de uma sala.
 </br>
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
|-----|------------------------------------|


 

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



<h1>Salas</h1>
É necessário estar logado para ter acesso a qualquer uma das funcionalidade da api relacionadas as salas 
 
 </br>
 </br>
 
<h2>Criando uma sala</h2>
Para inserir uma sala basta informar no Headers a key Authorization com os valores recebidos na autenticação e no body inserir o nome da sala e descrição da sala.

| POST | SeuDominio.com.br/api/salas |
|------|-----------------------------|

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

</br>
</br>


<h3>Listar salas</h3>
Para listar todas as salas basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| GET | SeuDominio.com.br/api/salas |
|-----|-----------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64351402-9f0bab00-cfd0-11e9-8322-8452cbbbf15c.png)

![image](https://user-images.githubusercontent.com/37151034/64353279-e182b700-cfd3-11e9-9805-4c07e902417b.png)

</br>
</br>

<h3>Buscar uma sala</h3>
Para buscar uma sala basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| GET | SeuDominio.com.br/api/salas/5 |
|-----|-------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64351402-9f0bab00-cfd0-11e9-8322-8452cbbbf15c.png)

![image](https://user-images.githubusercontent.com/37151034/64353542-4fc77980-cfd4-11e9-9580-92f970153553.png)


</br>
</br>

<h3>Deletar uma sala</h3>
Para deletar uma sala basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| DELETE | SeuDominio.com.br/api/salas/5 |
|-----|----------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64351402-9f0bab00-cfd0-11e9-8322-8452cbbbf15c.png)

![image](https://user-images.githubusercontent.com/37151034/64353688-8b624380-cfd4-11e9-94ea-ed120b26be92.png)


</br>

<h3>Alterar uma sala</h3>
Para alterar uma sala basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| DELETE | SeuDominio.com.br/api/salas |
|-----|--------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64351402-9f0bab00-cfd0-11e9-8322-8452cbbbf15c.png)

![image](https://user-images.githubusercontent.com/37151034/64354024-0b88a900-cfd5-11e9-80b2-8d8b34483d35.png)




















<h1>Agendamento de salas</h1>
É necessário estar logado para ter acesso a qualquer uma das funcionalidade da api relacionadas aos agendamentos das salas
 
 </br>
 </br>
 
<h2>Criando um Agendamento</h2>
Para inserir um agendamento basta informar no Headers a key Authorization com os valores recebidos na autenticação e no body inserir as informações necessárias para um agendamento.

| POST | SeuDominio.com.br/api/salasagendadas |
|------|--------------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64355606-e21d4c80-cfd7-11e9-8601-f175c57ddfe1.png)

<h3>Informações da sala</h3>

| Nome da variável | Tipo da variável | Descrição                         | Obrigatório |
|------------------|------------------|-----------------------------------|-------------|
| SalasId          | int              | Id da sala que será utilizada     | Sim         |
| Titulo           | string           | Título da reunião                 | Sim         |
| DataInicio       | DateTime         | Data e hora do ínicio             | Sim         |
| DataFim          | DateTime         |  Data e hora do ínicio            | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64354860-97e79b80-cfd6-11e9-8892-fb293798f507.png)

</br>
</br>


<h3>Listar agendamentos</h3>
Para listar todos os agendamentos basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| GET | SeuDominio.com.br/api/salasagendadas |
|-----|--------------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64355606-e21d4c80-cfd7-11e9-8601-f175c57ddfe1.png)

![image](https://user-images.githubusercontent.com/37151034/64355189-25c38680-cfd7-11e9-94e0-003cd3c32379.png)

</br>
</br>

<h3>Buscar um agendamento</h3>
Para buscar um agendamento basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| GET | SeuDominio.com.br/api/salasagendadas/5 |
|-----|----------------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64355606-e21d4c80-cfd7-11e9-8601-f175c57ddfe1.png)

![image](https://user-images.githubusercontent.com/37151034/64355284-4d1a5380-cfd7-11e9-81d5-829e1aab6c35.png)


</br>
</br>

<h3>Deletar um agendamento</h3>
Para deletar um agendamento basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| DELETE | SeuDominio.com.br/api/salasagendadas/5 |
|--------|----------------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64355606-e21d4c80-cfd7-11e9-8601-f175c57ddfe1.png)

![image](https://user-images.githubusercontent.com/37151034/64355357-74712080-cfd7-11e9-8671-5a78f8847178.png)


</br>

<h3>Alterar um agendamento</h3>
Para alterar um agendamento basta informar no Headers a key Authorization com os valores recebidos na autenticação.

| POST | SeuDominio.com.br/api/salasagendadas |
|------|--------------------------------------|

<h3>Autenticação</h3>

| Nome da variável | Tipo da variável | Descrição                                      | Obrigatório |
|------------------|------------------|------------------------------------------------|-------------|
| Authorization    | string           | token_type e access token fornecido pela api   | Sim         |

![image](https://user-images.githubusercontent.com/37151034/64355606-e21d4c80-cfd7-11e9-8601-f175c57ddfe1.png)

![image](https://user-images.githubusercontent.com/37151034/64355474-ae422700-cfd7-11e9-80c5-7c7330dca72d.png)

