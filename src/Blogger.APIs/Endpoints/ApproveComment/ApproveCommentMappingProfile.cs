﻿using Blogger.Application.Usecases.ApproveComment;

namespace Blogger.APIs.Contracts.ApproveComment;

public class ApproveCommentMappingProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.ForType<ApproveCommentRequest, ApproveCommentCommand>()
                   .Map(x => x.Link, src => src.Link);
    }
}
