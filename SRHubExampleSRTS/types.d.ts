// AUTO GENERATED - DO NOT EDIT MANUALLY
// Assembly File:C:\Users\nwolverson\Documents\Visual Studio 2013\Projects\SignalRTest\SRHubExampleSRTS\bin\SRHubsTT.dll


/* Sample code -- create a .ts file, and paste the following to get started

	/// <reference path="types.d.ts" />
	/// <reference path="signalr.d.ts" />

	// Proxies 
	var chatHub: IChatHubProxy = (<any>$.connection).chatHub;

	// Client implementations go here... add some functions.
	chatHub.client = { 

	};

	$.connection.hub.start().done((a) => {
		// alert('connected.'); 
		// (do something) 
	});

*/

// Client interfaces. These are the return types for the proxies.
// Implement these in your .ts file, but do not manually edit them here. 
interface IChatHubClient { }

// Data interfaces 

// Hub interfaces 
interface IChatHub {
    send(name: string, message: string): IPromise<void>;
}

// Generetated proxies 
interface IChatHubProxy {
     server: IChatHub;
     client: IChatHubClient;
}
