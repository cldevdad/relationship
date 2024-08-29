# Relationship

## Overview

Relationship is a comprehensive framework designed to model and manage the core dynamics of interpersonal relationships. This project encapsulates essential relationship elements such as patience, trust, and love, providing mechanisms to nurture these elements and handle complex challenges through a strategy-based approach.

## Features

- **Foundation Class**: Central to the project, the `Foundation` class manages the key components of a relationship—patience, trust, and love. It provides methods to nurture these aspects and evaluate the overall strength of the relationship.
- **Custom Exceptions**: The project includes specific exceptions to represent common relationship challenges:

  - `BrokenTrustException`: Thrown when trust is compromised within the relationship.
  - `LackOfPatienceException`: Thrown when patience reaches critical levels.
  - `FadingLoveException`: Thrown when love diminishes over time.
  - `CheatedWithBestFriendsSonException`: Represents severe betrayal and its implications.

- **HumbleAndKind Strategy**: This class provides a structured approach to handle relationship challenges gracefully. It includes methods for addressing and potentially resolving each type of exception, promoting empathy, understanding, and reconciliation.

## Installation

Clone the repository to your local machine:

```bash
git clone https://github.com/yourusername/RelationshipProject.git
```

Navigate to the project directory:

```bash
cd RelationshipProject
```

Ensure you have .NET installed, then build and run the project:

```bash
dotnet build
dotnet run
```

## Usage

The `Program.cs` file demonstrates how to utilize the `Foundation` class to model a relationship and how to handle various challenges using the `HumbleAndKind` strategy.

### Example

In the `Main` method, different scenarios such as broken trust, lack of patience, fading love, and severe betrayal are simulated. The `HumbleAndKind` strategy is employed to handle these exceptions and suggest ways to address the underlying issues.

## Contributing

This is a collaborative and supportive environmen. Contributions are welcome and appreciated. Each contribution helps to build and strengthen our collective efforts. Together, we can make Relationships better and more impactful.

## License

This project is licensed, with love, under the MIT License. See the `LICENSE` file for more details.
