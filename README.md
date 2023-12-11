# OpenAI Windows Forms App

This Windows Forms application written in C# allows you to interact with the OpenAI API using the GPT-4 model (text-davinci-002) to generate responses from questions or prompts you provide. The application interface is simple and consists of two TextBoxes and a button.

## Features

- Send questions or prompts to the GPT-4 API and display real-time responses.
- Configure request parameters such as temperature, max_tokens, n responses, and API Key.
- Save the configuration to a file so you don't have to reconfigure it each time you use the application.

## Screenshots

![image](https://github.com/carlosmurias/OpenAiWinForms/assets/18576582/670b179b-8a78-4cb5-b7d9-01359fa6740d)
![image](https://github.com/carlosmurias/OpenAiWinForms/assets/18576582/f51706f9-ea77-4142-b129-b534636fa6e1)


## Quick Start

Follow these steps to start using the application:

1. Clone or download the repository to your local machine.
2. Open the project in Visual Studio (or your preferred IDE) and build it.
3. Run the application.
4. In the main application window, enter a question or prompt in the first TextBox.
5. Click the "Send" button to obtain a response from the API, which will be displayed in the second TextBox.

## Configuration

You can customize the application's settings using the configuration window. Here, you can adjust the following parameters:

- **API Key**: Enter your OpenAI API key to authorize requests to the API.
- **Temperature**: Control the randomness of responses generated by the model (0.0 for more deterministic responses, 1.0 for more random responses).
- **Max Tokens**: Limit the maximum length of generated responses.
- **n Responses**: Specify how many responses you want to get from the API in a single request.

## Dependencies

The application uses the following dependencies:

- .NET Framework (or .NET Core if preferred).
- OpenAI API (make sure you have a valid OpenAI API key).

## Contributing

If you'd like to contribute to this project, feel free to fork and submit pull requests. We're open to improvements and new features.

## License

This project is licensed under the [MIT License](LICENSE).