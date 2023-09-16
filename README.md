# InLock_EFrameWork_CodeFirst 📚
Uma empresa do ramo de games, a **InLock**, deseja realizar a criação de sua base de dados
para armazenar os **jogos que são vendidos em sua loja**. Além disso, como eles já
possuem um desenvolvedor Front-End atuando na empresa, **não será necessário**
construir a interface com o usuário final. Para isto, deverá ser **desenvolvida uma API**
(trabalhando com JSON), para que o Front-End (seja web ou mobile) realize a construção
com base nas informações fornecidas.

## Conceituando sobre a estrutura Code do Entity Framework (EF) 📏
O **Entity Framework Code First** é uma abordagem de desenvolvimento de aplicativos que faz parte do Entity Framework, um framework de **mapeamento objeto-relacional (ORM**) desenvolvido pela Microsoft. O objetivo principal do **Entity Framework Code First** é permitir que você defina o modelo de dados do seu aplicativo usando código C# (ou outra linguagem suportada) em vez de criar um modelo de banco de dados primeiro e, em seguida, gerar classes a partir desse banco de dados.
##
**Aqui estão os conceitos-chave do Entity Framework Code First:**

**• Modelo de Dados em C#:** Você define suas classes de entidade em C# para representar as tabelas e relacionamentos do banco de dados. Cada classe de entidade corresponde a uma tabela no banco de dados.

**• Convenções:** O Entity Framework Code First usa convenções para inferir o mapeamento entre suas classes de entidade e as tabelas do banco de dados. Por exemplo, nomes de classes e propriedades são usados para determinar os nomes das tabelas e colunas, mas você pode configurar essas convenções se necessário.

**• Anotações de Atributo:** Você pode usar atributos para fornecer informações adicionais ao Entity Framework sobre como mapear suas classes de entidade para o banco de dados. Por exemplo, você pode usar atributos para definir chaves primárias, tipos de dados, restrições de tamanho e muito mais.

**• Fluent API:** Além das anotações de atributo, o Entity Framework Code First oferece uma Fluent API que permite configurar o mapeamento de entidades de forma mais flexível e detalhada. Isso é útil quando você precisa de mais controle sobre o mapeamento.

**• Contexto do Banco de Dados:** Você cria uma classe de contexto de banco de dados que herda de DbContext. O contexto do banco de dados é responsável por gerenciar a conexão com o banco de dados, rastrear alterações nas entidades e realizar operações de consulta e atualização no banco de dados.

**• Migrações:** O Entity Framework Code First também suporta migrações de banco de dados. Isso permite que você faça alterações no modelo de dados do seu aplicativo e atualize automaticamente o esquema do banco de dados para refletir essas alterações sem perder dados existentes.

**• Criação do Banco de Dados:** O Entity Framework pode criar automaticamente o banco de dados com base no modelo de dados definido em suas classes de entidade, ou você pode especificar um banco de dados existente para usar.
##
O **Entity Framework Code First** é uma abordagem poderosa e flexível para o desenvolvimento de aplicativos que envolvem banco de dados, permitindo que você se concentre mais na lógica de negócios e menos na criação manual do esquema do banco de dados. Ele é particularmente útil em cenários de desenvolvimento ágil, onde os requisitos do banco de dados podem evoluir ao longo do tempo.




