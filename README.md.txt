# Gerenciador de Máquinas com Mapa

Este projeto é uma aplicação full stack composta por um **frontend Angular** e um **backend .NET**, utilizada para **cadastrar, visualizar, editar e filtrar máquinas por status**, além
de visualizar sua localização em um **mapa interativo (Leaflet)**.

---

## 🧩 Tecnologias Utilizadas

### Frontend
- Angular
- Leaflet (OpenStreetMap)
- TypeScript
- HTML/CSS

### Backend
- ASP.NET Core Web API
- C#
- Entity Framework Core

---

## 🔧 Funcionalidades

- Cadastro de novas máquinas com:
  - Nome
  - Latitude / Longitude
  - Status (Operando, Desligada, Em Manutenção)
- Filtro de máquinas por status
- Visualização dos dados em modais
- Visualização geográfica em mapa interativo com Leaflet
- Edição de máquinas existentes
- API RESTful para comunicação entre frontend e backend

---

## 🚀 Como Executar o Projeto

### Pré-requisitos

- Node.js (v16+)
- Angular CLI
- .NET SDK (v6.0+)
- Visual Studio ou VS Code

---

### 📁 Estrutura do Projeto

MachineCRUD/
├── Backend/MachineTelemetryAPI
│ ├── Controllers/
│ ├── Models/
│ ├── Services/
│ ├── Program.cs
│ └── ...
├── Frontend/MachineTelemetryInterface
│ ├── src/
│ ├── app/
│ ├── app.component.ts
│ ├── app.html
│ └── ...
└── README.md

### 🛠 Backend (.NET)

1. Navegue até a pasta do backend:
2. Abra o projeto com o Visual Studio Comunnity
3. Selecione o protocolo http e rode a aplicação
4. Olhe para o console, caso a porta seja diferente de 5210, deve ser ajustada no frontend em src/app/services/machine.service.ts para a sua porta

🌐 Frontend (Angular)
Navegue até a pasta do frontend:

1. Abra o folder machine-telemetry no Visual Studio Code
2. No terminal, instale as dependências com: npm install
3. Após, executar a aplicação no terminal com: ng serve
4. Acesse no navegador: http://localhost:4200

📍 Observações Importantes
1. O projeto aceita coordenadas reais. Exemplo:
   Rua João Zani, 450D – Bairro Maria Goretti → aproximadamente:
   latitude: -27.0947, longitude: -52.6158
2. O projeto salva os dados da aplicação em memória no backend, ao abrir o projeto deve ser inserido registros para testes.
3. Os dados são mantidos em memória pelo backend. Como não há banco de dados persistente, os códigos das máquinas são gerados automaticamente e podem ser visualizados na aba View.
4. Os campos do formulário tem validações:
   Name: não pode ser nulo
   Latitude: deve estar entre -90 e 90
   Longitude: deve estar entre -180 e 180
5. Na coluna **Actions**:
   - ✏️ Edit: editar status e localização
   - 👁️ View: visualizar os dados detalhados
   - 🗺️ Map: visualizar a máquina em um mapa (Leaflet)