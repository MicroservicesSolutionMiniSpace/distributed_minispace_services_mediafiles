using Convey.CQRS.Events;
using MiniSpace.Services.Email.Application.Services;
using MiniSpace.Services.Email.Core;
using MiniSpace.Services.Email.Core.Events;

namespace MiniSpace.Services.Email.Infrastructure.Services
{
    public class EventMapper : IEventMapper
    {
        public IEnumerable<IEvent> MapAll(IEnumerable<IDomainEvent> events)
            => events.Select(Map);

        public IEvent Map(IDomainEvent @event)
        {
            switch (@event)
            {
                case NotificationCreated e:
                    return new MiniSpace.Services.Notifications.Application.Events.External.NotificationCreated(
                        e.NotificationId, e.UserId, e.Message, e.CreatedAt);
                case NotificationUpdated e:
                    return new MiniSpace.Services.Notifications.Application.Events.External.NotificationUpdated(
                        e.NotificationId, e.UserId, e.NewStatus);
                case NotificationDeleted e:
                    return new MiniSpace.Services.Notifications.Application.Events.External.NotificationDeleted(
                         e.UserId, e.NotificationId);
            }

            return null;
        }
    }
}
