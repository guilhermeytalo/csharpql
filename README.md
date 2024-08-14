
# CSharpQL

CSharpQL is a GraphQL project built using C#. This repository demonstrates the implementation of a GraphQL server, including the setup of queries, mutations, and schema definitions.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Examples](#examples)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/guilhermeytalo/csharpql.git
   cd csharpql
   ```

2. **Restore dependencies:**

   ```bash
   dotnet restore
   ```

3. **Build the project:**

   ```bash
   dotnet build
   ```

## Usage

1. **Run the GraphQL server:**

   ```bash
   dotnet run
   ```

2. **Access the GraphQL playground:**

   Open your browser and navigate to `http://localhost:5000/graphql` to explore the GraphQL API.

## Features

- **GraphQL Schema Definition:** Defines the schema for your API, including queries, mutations, and types.
- **Query Support:** Includes sample queries for fetching data.
- **Mutation Support:** Provides examples of how to modify data using mutations.
- **Mock Data Generation:** Utilizes the `Bogus` library to generate mock data for testing and development.

## Examples

### Sample Query

```graphql
query {
  sampleQuery {
    id
    name
    description
  }
}
```

### Sample Mutation

```graphql
mutation {
  sampleMutation(input: { name: "Example" }) {
    id
    name
    description
  }
}
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
