# Calendar

Please write a calendar app which meets requirements outlined below. Depending on what skills you want to show you may choose to implement only backend (and expose appropriate API) or you may choose to implement both frontend and backend code.

Please attach a "commentary" to your code (in a separate markdown file) explaining your design and concepts behind it. Remember to provide tests and explain why did you choose to test your code that way. Code should be provided as git repository with commit history.


## Requirements

The most basic requirements are:

- each user may use a different time zone
- event has a title and a description
- event always belongs to a single calendar
- calendar always has a single owner (user)
- calendar has a name and a color assigned to it
- event can be time-specific or "all day"
- when event is time specific it must be aware of the timezone
- "all day" event always span the whole day, regardless of the user time zone
- event always has start and end time

### Requirements: Sharing

- calendar may be shared with other users of the system
- two levels of access: read and write
- write access allows for modification of all events in that calendar

### Requirements: Reminders

- multiple reminders can be set for an event
- reminders have defaults for calendar
- every user can have different reminders for a single event
- calendar has default reminder settings (separate for each user)
- reminder can be dismissed
- reminder can be snoozed (reminder will be displayed again in 10 minutes)
- for all-day events it should be possible for user to configure at what time should the reminder be displayed (good default would be 8 AM)

### Requirements: Invitations

- event can have a list of guests - other users of the app
- users invited to event should see the event in their calendar app
- guest user should be able to edit an event, but only that guest should see those changes
- guest or an owner should be able to RSVP

### Requirements: Recurring Events

- event can have a recurring pattern (you may use RRULE for that)
- event may be repeated unlimited number of times (no end date)
- single event occurrence may be deleted without deleting other events in series
- single event occurrence can be changed without changing other event occurrences (including changing start/end time or guest list)
- users may be invited to a single occurrence or whole series
- user may choose if edit should affect a single occurrence or whole series
