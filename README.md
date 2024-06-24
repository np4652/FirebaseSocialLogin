# Login With Google using Firebase in .NET Core 8.0 and jQuery

## Overview

This project demonstrates how to implement Google Login functionality using Firebase Authentication in a .NET Core 8.0 application with jQuery for the frontend. The aim is to provide a seamless and secure authentication mechanism leveraging Firebase's robust authentication system and Google's OAuth2.

## Features

- User Authentication via Google
- Firebase integration for managing authentication
- Simple and clean user interface using jQuery
- Secure handling of authentication tokens
- .NET Core 8.0 backend for server-side processing

## Prerequisites

- .NET Core 8.0 SDK
- Node.js (for npm)
- Google Firebase Account
- Google Cloud Platform (GCP) project with OAuth 2.0 credentials

## Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/GoogleLoginWithFirebase.git
cd GoogleLoginWithFirebase
```

### 2. Configure Firebase

1. Go to the [Firebase Console](https://console.firebase.google.com/).
2. Create a new project or select an existing project.
3. Navigate to **Authentication** and enable **Google Sign-In**.
4. Copy the Firebase configuration object (apiKey, authDomain, projectId, etc.).

### 3. Download Firebase Admin SDK:

In the Firebase Console, go to Project Settings.
Click on "Service accounts" and then "Generate new private key".
Save the JSON file containing your service account credentials.

### 4. Configure the Application
1. Move the downloaded JSON file to your project directory and ensure it’s included in your project.
2. Initialize Firebase in your Startup.cs or Program.cs file:
3. 
### 5. Install Dependencies

```bash
npm install
dotnet restore
```

### 6. Run the Application

```bash
dotnet run
```

### 7. Access the Application

Navigate to `http://localhost:{PORT}` in your web browser.


```

## Authentication Flow

1. User clicks the "Login with Google" button.
2. jQuery triggers the Firebase Google Sign-In method.
3. Firebase handles the authentication and returns a token.
4. The token is sent to the .NET Core backend for validation.
5. On successful validation, the user is authenticated and can access secure endpoints.

## Contributing

Contributions are welcome! Please submit a pull request or open an issue to discuss improvements or bugs.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any queries or issues, please contact [yourname@example.com](mailto:yourname@example.com).

---

Feel free to customize this README to fit your project's specific details and requirements.
