// Fill out your copyright notice in the Description page of Project Settings.


#include "JwtHelper.h"
#include "UnrealString.h"
#include "jwt.h"
#include <string>

void UJwtHelper::DecodeToken(const FString& InToken)
{
	if (InToken.IsEmpty()) return;
	auto decoded = jwt::decode(TCHAR_TO_ANSI(*InToken));

	for (auto& Item : decoded.get_payload_claims())
	{
		FString first = Item.first.c_str();
		FString Second = Item.second.to_json().serialize().c_str();
		UE_LOG(LogTemp,Log, TEXT("first = %s,second = %s"), *first, *Second);

	}
}
