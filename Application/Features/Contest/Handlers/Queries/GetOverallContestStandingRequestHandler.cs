// using System;
// using Application.Contracts;
// using Application.DTOs;
// using AutoMapper;
// using MediatR;

// namespace Application.Features.Contest.Handlers.Queries
// {
// 	public class GetOverallContestStandingRequestHandler : IRequestHandler<GetOverallContestStandingRequest, List<UserContestHistoryDto>>
// 	{
//         private readonly IUserContestHistoryRepository _userContestHistoryRepository;
//         private readonly IMapper _mapper;


//         public GetOverallContestStandingRequestHandler(IUserContestHistoryRepository userContestHistoryRepository, IMapper mapper)
// 		{
//             _userContestHistoryRepository = userContestHistoryRepository;
//             _mapper = mapper;
// 		}

//         public async Task<List<UserContestHistoryDto>> Handle(GetOverallContestStandingRequest request, CancellationToken cancellationToken)
//         {
//             await _userContestHistoryRepository.GetOverallContestStanding;
//             return _mapper.Map<>();
//         }
//     }
// }

