using hm12_task1_delegate;

string name = "ADMIN";

TextMessage message = new TextMessage();
Action<string> action = message.OutputGreeting;
action += message.OutputTodayDate;
action += message.OutputTodayTime;
action += message.OutputFarewell;

action.Invoke(name);